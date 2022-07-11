using Microsoft.AspNetCore.Mvc;
using RunGroopWebApp.Data.Enum;
using RunGroopWebApp.Helpers;
using RunGroopWebApp.Interfaces;
using RunGroopWebApp.Models;
using RunGroopWebApp.ViewModels;

namespace RunGroopWebApp.Controllers
{
    public class ClubController : Controller
    {
        private readonly IClubRepository _clubRepository;
        private readonly IPhotoService _photoService;

        public ClubController(IClubRepository clubRepository, IPhotoService photoService)
        {
            _clubRepository = clubRepository;
            _photoService = photoService;
        }

        //Página Principal que  lista todos os clubs
        public async Task<IActionResult> Index()
        {
            IEnumerable<Club> clubs = await _clubRepository.GetAll();
            return View(clubs);
        }

        //Página de Detalhes
        public async Task<IActionResult> Detail(int id) 
        {
            Club club = await _clubRepository.GetByIdAsync(id);
            return View(club);
        }

        //Página de Criação de novos clubs
        public IActionResult Create()
        {
            return View();
        }

        //Postagem (Aqui é responsável pelo método de criação dos clubs)
        [HttpPost]
        public async Task<IActionResult> Create(CreateClubViewModel clubVM)
        {
            if (ModelState.IsValid)
            {
                //return View(club);
                var result = await _photoService.AddPhotoAsync(clubVM.Image);
                var club = new Club
                {
                    Title = clubVM.Title,
                    Description = clubVM.Description,
                    Image = result.Url.ToString(),
                    Address = new Address
                    {
                        Street = clubVM.Address.Street,
                        City = clubVM.Address.City,
                        State = clubVM.Address.State,
                    }
                }; 
                _clubRepository.Add(club);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Photo Upload failed");
            }

            return View(clubVM);
        }

        //Página de Editar
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditClubViewModel clubVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit club");
                return View("Edit", clubVM);
            }

            var userClub = await _clubRepository.GetByIdAsyncNoTracking(id);

            if (userClub == null)
            {
                return View("Error");
            }

            var photoResult = await _photoService.AddPhotoAsync(clubVM.Image);

            if (photoResult.Error != null)
            {
                ModelState.AddModelError("Image", "Photo upload failed");
                return View(clubVM);
            }

            if (!string.IsNullOrEmpty(userClub.Image))
            {
                _ = _photoService.DeletePhotoAsync(userClub.Image);
            }

            var club = new Club
            {
                Id = id,
                Title = clubVM.Title,
                Description = clubVM.Description,
                Image = photoResult.Url.ToString(),
                AddressId = clubVM.AddressId,
                Address = clubVM.Address,
            };

            _clubRepository.Update(club);

            return RedirectToAction("Index");
        }
    }
}
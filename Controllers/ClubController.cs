using Microsoft.AspNetCore.Mvc;
using RunGroopWebApp.Data;
using RunGroopWebApp.Models;
using RunGroopWebApp.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace RunGroopWebApp.Controllers
{
    public class ClubController : Controller
    {
        private readonly IClubRepository _clubRepository;

        public ClubController(IClubRepository clubRepository)
        {
            _clubRepository = clubRepository;
        }

        public async Task<IActionResult> Index() //CCCCC
        {
            IEnumerable<Club> clubs = await _clubRepository.GetAll();
            return View(clubs); //VVVV
        }

        //Página de Detalhes
        public async Task<IActionResult> Detail(int id) 
        {
            Club club = await _clubRepository.GetByIdAsync(id);
            return View(club);
        }

        
    }
}
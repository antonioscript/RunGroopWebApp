using Microsoft.AspNetCore.Mvc;
using RunGroopWebApp.Data;
using RunGroopWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace RunGroopWebApp.Controllers
{
    public class ClubController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClubController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index() //CCCCC
        {
            List<Club> clubs = _context.Clubs.ToList(); //MMMM
            return View(clubs); //VVVV
        }

        //Página de Detalhes
        public IActionResult Detail(int id) 
        {
            Club club = _context.Clubs.Include(a => a.Address).FirstOrDefault(c => c.Id == id);
            return View(club);
        }

        
    }
}
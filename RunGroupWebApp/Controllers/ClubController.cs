using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroupWebApp.Data;

namespace RunGroupWebApp.Controllers
{
    public class ClubController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClubController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var clubs = _context.Clubs.ToList();
            return View(clubs);
        }
        
        public IActionResult Details(int id)
        {
            var clubs = _context.Clubs.Include(a=>a.Address).FirstOrDefault(a=>a.Id == id);
            return View(clubs);
        }
    }
}

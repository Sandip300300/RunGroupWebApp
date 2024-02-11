using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroupWebApp.Data;
using RunGroupWebApp.Interfaces;
using System.Runtime.CompilerServices;

namespace RunGroupWebApp.Controllers
{
    public class ClubController : Controller
    {
        private readonly ICLubRepository _cLubRepository;

        public ClubController(ICLubRepository cLubRepository)
        {
            _cLubRepository = cLubRepository;
        }
        public async Task<IActionResult> Index()
        {
            var clubs = await _cLubRepository.GetAll();
            return View(clubs);
        }
        
        public async Task<IActionResult> Details(int id)
        {
            var clubs = await _cLubRepository.GetByIdAsync(id);
            return View(clubs);
        }
    }
}

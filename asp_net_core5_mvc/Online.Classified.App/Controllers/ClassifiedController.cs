using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online.Classified.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online.Classified.App.Controllers
{
    public class ClassifiedController : Controller
    {
        private readonly AradaLejDbContext _context;

        public ClassifiedController(AradaLejDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MyAds()
        {
            return View();
        }
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _context.Classified.ToListAsync() });
        }

    }
}

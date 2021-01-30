using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Online.Classified.App.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Online.Classified.App.Controllers
{
    public class HomeController : Controller
    {
     
        private readonly AradaLejDbContext _context;
        public HomeController(AradaLejDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var classified = await _context.Classified.ToListAsync();
            return View(classified);
        }
        public IActionResult RecentClassified()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

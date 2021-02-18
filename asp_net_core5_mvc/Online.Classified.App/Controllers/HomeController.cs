using Microsoft.AspNetCore.Mvc;

using Online.Classified.Data;


using System.Diagnostics;


namespace Online.Classified.App.Controllers
{
    public class HomeController : Controller
    {
     
        private readonly IClassifiedService _classifiedService;
        public HomeController(IClassifiedService classifiedService)
        {
            _classifiedService = classifiedService;
        }

        public IActionResult Index()
        {
            var classified = _classifiedService.GetAll();
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

        
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Project.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProject _projectService;

        public HomeController(IProject projectService)
        {
            _projectService = projectService;
        }

        public IActionResult Index()
        {
            var projects = _projectService.GetAll();
            return View(projects);
        } 

        public IActionResult Detail(int id)
        {
            var project = _projectService.GetById(id);
            return View(project);
        }


    }
}

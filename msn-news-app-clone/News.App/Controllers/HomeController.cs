using News.App.Models;
using News.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace News.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IPostService _postService; 

        public HomeController(ICategoryService categoryService, IPostService postService)
        {
            _categoryService = categoryService;
            _postService = postService;
        }

        public IActionResult Index()
        {
            var posts = _postService.GetAll().OrderByDescending(post=>post.Id);
            return View(posts);
        }
        public IActionResult Posts(int id)
        {
           
            var posts = _postService.GetByCategory(id);
            ViewData["Category"] = _categoryService.GetCategoryTitle(id);
            return View(posts);
        }
       public IActionResult Detail(int id)
        {
            var post = _postService.GetById(id);
            return View(post);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using News.App.Models;
using News.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using News.Data.Models;


namespace News.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IPostService _postService;
        [BindProperty]
        public Post Post { get; set; }
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
        public IActionResult Manage()
        {
            return View();
        }
        public IActionResult Posts(int id)
        {
           
            var posts = _postService.GetByCategory(id);
            ViewData["Category"] = _categoryService.GetCategoryTitle(id);
            ViewData["TotalPosts"] = _postService.GetNumberOfNews(id);
            ViewData["Image"] = _categoryService.GetCategoryImage(id);

            return View(posts);
        }
       public IActionResult Detail(int id)
        {
            var categoryId = _postService.GetCategoryId(id);
           
            ViewData["News"] = _postService.GetById(id);
            ViewData["RelatedNews"] = _postService.GetRelatedNews(categoryId, id);

            //var post = _postService.GetById(id);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Form(int? id)
        {
            Post = new Post();
            var categories = _categoryService.GetAll().ToList();
            categories.Insert(0, new Category { Id = 0, Name = "Select", Thumbnail = ""});
            ViewBag.ListOfCategory = categories;
            if (id == null)
            {
                //Create New
                return View(Post);
            }
            //Update
            Post = _postService.GetById(id);
            if (Post == null)
            {
                return NotFound();
            }
            return View(Post);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Form()
        {
            if (ModelState.IsValid)
            {
                if (Post.Id == 0)
                {
                    //CREATE
                    _postService.Add(Post, "new"); ;

                }
                else
                {
                //    _postService.Add(Post, "update");
                }


                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _postService.GetAll()) });

            }

            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Form", Post) });

        }


        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _postService.GetAll() });
        }

        public IActionResult Delete(int Id)
        {
            /*
            var isDeleted = _postService.Delete(Id);
            if (isDeleted == false)
            {
                return Json(new { success = false, message = "Error while deleting" });

            }
            */
            return Json(new { success = true, message = "Delete successful - deletion intentionally disabled on the demo site" });

        }


        #endregion
    }
}

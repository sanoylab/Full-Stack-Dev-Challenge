using News.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using News.Data.Models;

namespace News.App.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        [BindProperty]
        public Category Category { get; set; }
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var category = _categoryService.GetAll();
            return View(category);
        }
        public IActionResult Manage()
        {
            return View();
        }
        public IActionResult Form(int? id)
        {
            Category = new Category();
            if (id == null)
            {
                //Create New
                return View(Category);
            }
            //Update
            Category = _categoryService.GetById(id);
            if (Category == null)
            {
                return NotFound();
            }
            return View(Category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Form()
        {
            if (ModelState.IsValid)
            {
                if (Category.Id == 0)
                {
                    //CREATE
                    _categoryService.Add(Category, "new");

                }
                else
                {
                    _categoryService.Add(Category, "update");
                }


                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _categoryService.GetAll()) });

            }

            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Form", Category) });

        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _categoryService.GetAll() });
        }
        public IActionResult Delete(int id)
        {
            var isDeleted = _categoryService.Delete(id);
            if (isDeleted == false)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            return Json(new { success = true, message = "Delete successful" });
        }

        #endregion
    }
}

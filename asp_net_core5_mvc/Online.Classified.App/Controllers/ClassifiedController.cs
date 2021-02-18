using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online.Classified.Data;
using Online.Classified.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online.Classified.App.Controllers
{
    public class ClassifiedController : Controller
    {
        private readonly IClassifiedService _classifiedService;
        private readonly ICategoryService _categoryService;
        [BindProperty]
        public Online.Classified.Data.Models.Classified Classified { get; set; }
      
        public ClassifiedController(IClassifiedService classifiedService, ICategoryService categoryService)
        {
            _classifiedService = classifiedService;
            _categoryService = categoryService;
        }
        
        public IActionResult Index(int Id)
        {
            var classified = _classifiedService.GetByCategoryId(Id);
         

           


            return View(classified);
        }
        public IActionResult MyAds()
        {
            return View();
        }

        public IActionResult Form(int? id)
        {
            Classified = new Data.Models.Classified(); 
            var categories = _categoryService.GetAll().ToList(); 
            categories.Insert(0, new Category { Id = 0, Name = "Select", CategoryImage="", Status=true });
            ViewBag.ListOfCategory = categories;
            if (id == null)
            {
                //Create New
                return View(Classified);
            }
            //Update
            Classified = _classifiedService.GetById(id);
            if (Classified == null)
            {
                return NotFound();
            }
            return View(Classified);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Form()
        {
            if (ModelState.IsValid)
            {
                if (Classified.Id == 0)
                {
                    //CREATE
                    _classifiedService.Add(Classified, "add"); ;

                }
                else
                {
                    _classifiedService.Add(Classified, "update");
                }


                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _classifiedService.GetAll()) });

            }

            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "Form", Classified) });

        }




        #region API CALLS

        public IActionResult GetAll()
        {
            return Json(new { data = _classifiedService.GetAll() });
        }

        public IActionResult Delete (int Id)
        {
            var isDeleted = _classifiedService.Delete(Id);
            if(isDeleted == false)
            {
                return Json(new { success = false, message = "Error while deleting" });

            }
            return Json(new { success = true, message = "Delete successful" });

        }

        #endregion


    }
}

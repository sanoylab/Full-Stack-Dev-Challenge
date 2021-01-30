using Online.Classified.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online.Classified.App.Controllers
{
    public class CategoryController : Controller
    {
        //Populates all classified categories
        public ActionResult Index()
        {
            using (AradaLejDBContext aradaLejContext = new AradaLejDBContext())
            {
                var categorires = aradaLejContext.Category.OrderBy(a => a.Id).ToList();
                return View(categorires);

            }
        }
        [HttpGet]
        public ActionResult Create(int Id)
        {
            using (AradaLejDBContext _context = new AradaLejDBContext())
            {
                var category = _context.Category.Where(a => a.Id == Id).SingleOrDefault();
                return View(category);
            }
            
        }
        [HttpPost]
        [ActionName("Create")]
        public ActionResult Save(Category category)
        {
            if (ModelState.IsValid)
            {
                using(AradaLejDBContext _context = new AradaLejDBContext())
                {
                    if(category.Id > 0)
                    {
                        //edit
                        var c = _context.Category.Where(a => a.Id == category.Id).FirstOrDefault();
                        if (c != null)
                        {
                            c.CategoryImage = category.CategoryImage;
                            c.Name = category.Name;
                            c.Status = category.Status;
                        }
                    }
                    else
                    {
                        _context.Category.Add(category);
                      
                    }  
                    _context.SaveChanges();
                   
                }
                return RedirectToAction("ManageCategory", "Category");
            }
            return View();           
        }
        public ActionResult ManageCategory()
        {
            return View();
        }
        public ActionResult GetCategories()
        {
            using (AradaLejDBContext _context = new AradaLejDBContext())
            {
                var categories = _context.Category.OrderBy(a => a.Id).ToList();
                return Json(new { data = categories },JsonRequestBehavior.AllowGet);

            }
        }
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            bool result = false;
            using (AradaLejDBContext _context = new AradaLejDBContext())
            {
                var c = _context.Category.Where(a => a.Id == Id).SingleOrDefault();
                if (c != null)
                {
                    _context.Category.Remove(c);
                     _context.SaveChanges();
                    result = true;
                }
                return Json(result, JsonRequestBehavior.AllowGet);
                //return RedirectToAction("ManageCategory", "Category");
            }
        }
       
    }
}
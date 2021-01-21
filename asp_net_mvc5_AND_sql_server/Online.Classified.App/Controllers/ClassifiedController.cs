using Online.Classified.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online.Classified.App.Controllers
{
    public class ClassifiedController: Controller
    {

        //Populates all classified categories
        public ActionResult Categories ()
        {
            using (AradaLejDBContext aradaLejContext = new AradaLejDBContext())
            {
                var categorires = aradaLejContext.Category.OrderBy(a => a.Id).ToList();
                return View(categorires);
                
            }            
        }
        public ActionResult Index(int Id)
        {
            using (AradaLejDBContext aradaLejContext = new AradaLejDBContext())
            {
                var classifieds = aradaLejContext.Classified.OrderBy(a => a.Id).Where(a=>a.CategoryId == Id).ToList();
                return View(classifieds);               
            }
           
        }
        public ActionResult Detail(int Id)
        {
            using (AradaLejDBContext aradaLejContext = new AradaLejDBContext())
            {
                var classifieds = aradaLejContext.Classified.Single(a=>a.Id==Id);
                return View(classifieds);              
            }
        }
        public ActionResult MyClassified()
        {
            using(AradaLejDBContext _context = new AradaLejDBContext())
            {
                List<Online.Classified.App.Models.Classified> classifieds = _context.Classified.ToList();
                return Json(new { data = classifieds }, JsonRequestBehavior.AllowGet);
            }

        }
        public ActionResult MyAds()
        {
            return View();
        }
    }
}
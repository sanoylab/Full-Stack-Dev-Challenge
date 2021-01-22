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
        //GET API
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

        [HttpGet]
        public ActionResult PostAd(int Id)
        {
            using (AradaLejDBContext _context = new AradaLejDBContext())
            {
                var ad = _context.Classified.Where(a => a.Id == Id).FirstOrDefault();
                return View(ad);
            }
               
        }
        [HttpPost]

        public ActionResult PostAd(Models.Classified classified)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                using (AradaLejDBContext _context = new AradaLejDBContext())
                {
                    if(classified.Id > 0)
                    {
                        //edit
                        var v = _context.Classified.Where(a => a.Id == classified.Id).FirstOrDefault();
                        if (v != null)

                        {
                            v.CategoryId = classified.CategoryId;
                            v.Title = classified.Title;
                            v.PictureUrl = classified.PictureUrl;
                            v.Description = classified.Description;
                            v.Location = classified.Location;
                            v.Price = classified.Price;
                            v.PhoneNumber = classified.PhoneNumber;
                            v.IsRecommended = Convert.ToBoolean(classified.IsRecommended);
                        }

                    }
                    else
                    {
                        _context.Classified.Add(classified);
                    }
                    _context.SaveChanges();
                    status = true;
                }
                return RedirectToAction("MyAds");
            }
            return View();
        }
    }
}
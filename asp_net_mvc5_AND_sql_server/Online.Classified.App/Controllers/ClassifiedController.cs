using Online.Classified.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;


namespace Online.Classified.App.Controllers
{
    public class ClassifiedController: Controller
    {

        
        public ActionResult Index()
        {
            using (AradaLejDBContext aradaLejContext = new AradaLejDBContext())
            {
                var classifieds = aradaLejContext.Classified.OrderBy(a => a.Id).Where(a=>a.CategoryId == 1).ToList();
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
            
            using (AradaLejDBContext _context = new AradaLejDBContext())
            {
                List<Online.Classified.App.Models.Classified> classifieds = _context.Classified.ToList();
                return Json(new { data = classifieds }, JsonRequestBehavior.AllowGet);
            }

        }
        public ActionResult MyAds()
        {
            if (Session["user"] != null)
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
            
        }

        [HttpGet]
        public ActionResult PostAd(int Id)
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
                using (AradaLejDBContext _context = new AradaLejDBContext())
            {
                var category = _context.Category.Where(a=>a.Status==true).ToList();
                ViewBag.CategoryId = category;

                var ad = _context.Classified.Where(a => a.Id == Id).FirstOrDefault();
                return View(ad);
            }
               
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult PostAd(Models.Classified classified)
        {
            StringBuilder sbDescription = new StringBuilder();
            sbDescription.Append(HttpUtility.HtmlEncode(classified.Description));
            sbDescription.Replace("&lt;b&gt;", "<b>");
            sbDescription.Replace("&lt;/b&gt;", "</b>");
            sbDescription.Replace("&lt;u&gt;", "<u>");
            sbDescription.Replace("&lt;/u&gt;", "</u>");
            classified.Description = sbDescription.ToString();

            string title = HttpUtility.HtmlEncode(classified.Title);
            classified.Title = title;

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
                   
                }
                return RedirectToAction("MyAds");
            }
            return View();
        }
    }
}
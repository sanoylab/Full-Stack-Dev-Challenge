using Online.Classified.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Online.Classified.App.Controllers
{
    public class HomeController: Controller
    {
        public ActionResult Index()
        {
            using (AradaLejDBContext aradaLejContext = new AradaLejDBContext())
            {
                var classifieds = aradaLejContext.Classified.OrderBy(a => a.Id).Where(a=>a.CategoryId ==1 || a.IsRecommended ==true).ToList();
                return View(classifieds);
                //return Json(new { data = classifieds }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult ClassifiedList()
        {
            using (AradaLejDBContext aradaLejContext = new AradaLejDBContext())
            {
                var classifieds = aradaLejContext.Classified.OrderBy(a => a.Id).ToList();
                return PartialView(classifieds);
                //return Json(new { data = classifieds }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}
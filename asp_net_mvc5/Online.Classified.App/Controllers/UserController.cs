using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Online.Classified.App.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Login()
        {
            Models.User user = new Models.User();
            user.UserName = "admin";
            user.Password = "admin";

            return View(user);
        }
        [HttpPost]
        [ActionName("Login")]
        public ActionResult UserLogin()
        {
            Session["user"] = "admin";
            return RedirectToAction("MyAds", "Classified");
        }
        public ActionResult Logout()
        {
            Session["user"] = null;
            return RedirectToAction("Index", "Home");

        }
    }
}
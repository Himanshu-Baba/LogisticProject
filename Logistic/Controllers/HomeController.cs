using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Logistic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Your index page.";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your about page.";

            return View();
        }
        public ActionResult Services()
        {
            ViewBag.Message = "Your services page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Signup()
        {
            ViewBag.Message = "Your signup page.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your login page.";

            return View();
        }
        public ActionResult OTP()
        {
            ViewBag.Message = "Your otp page.";

            return View();
        }
    }
}
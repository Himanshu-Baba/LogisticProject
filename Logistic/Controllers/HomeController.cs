using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataBaseAccessLayer.Repository;
using DataBaseAccessLayer.Model;

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
        [HttpPost]
        public ActionResult Contact(ContactUsModel model)
        {
            ViewBag.Message = "Your contact page.";
            ContactUsDB oInsertContactUs = new ContactUsDB();
            oInsertContactUs.ContactUs(model);
            return RedirectToAction("Index");
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
        public ActionResult ForgotPassword()
        {
            ViewBag.Message = "Your ForgotPassword page.";

            return View();
        }

        public ActionResult ConfirmPassword()
        {
            ViewBag.Message = "Your ConfirmPassword page.";

            return View();
        }
        [HttpGet]
        public ActionResult Enquiry()
        {
            ViewBag.Message = "Your Enquiry page.";
            EnquiryTypeDropDownDB oEnquiryTypeDropDownDB = new EnquiryTypeDropDownDB();
            EnquiryModel obj = new EnquiryModel();
            obj.EnquiryTypeList = oEnquiryTypeDropDownDB.GetEnquiryType();

            ViewBag.StateList = new SelectList(oEnquiryTypeDropDownDB.GetState(), "StateId", "State");
            return View(obj);
        }
        [HttpPost]
        public ActionResult Enquiry(EnquiryModel data)
        {
            ViewBag.Message = "Your Enquiry page.";
            EnquiryDB oEnquiryDB = new EnquiryDB();
            oEnquiryDB.Enquiry(data);
            return RedirectToAction("Index");
        }

        public ActionResult GetCityList(int StateID)
        {
            EnquiryTypeDropDownDB oEnquiryTypeDropDownDB = new EnquiryTypeDropDownDB();
            List<CityModel> selectList = oEnquiryTypeDropDownDB.GetCity().Where(x => x.StateId == StateID).ToList();
            ViewBag.Citylist = new SelectList(selectList, "CityId", "City");
            return PartialView("P_DisplayCities");
        }

    }
}
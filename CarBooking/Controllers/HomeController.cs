using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarBooking.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Query()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Pass()
        {
            ViewBag.Title = "Home Page";

            return View();
        }



        public ActionResult Dashboard()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult inValid()
        {
            ViewBag.Title = "Home Page";

            return View();
        }



    }

}

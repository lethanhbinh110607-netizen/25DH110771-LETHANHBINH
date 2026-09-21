using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _25DH110771_LETHANHBINH.Controllers
{
    public class lab01Controller : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult BT1_lab01a()
        {
            return View();
        }

        public ActionResult BT2_lab01a()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult BT3_lab01a()
        {
            return View();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS_CS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult prekiu_grazinimas()
        {
            return View();
        }
        public ActionResult grazinimo_formos()
        {
            return View();
        }
        public ActionResult israsas()
        {
            return View();
        }
        public ActionResult grazinimo_patvirtinimas()
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
    }
}
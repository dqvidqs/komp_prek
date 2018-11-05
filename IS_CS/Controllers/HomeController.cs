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
        public ActionResult krepselio_perziura()
        {
            return View();
        }
        public ActionResult pristatymo_budai()
        {
            return View();
        }
        public ActionResult apmokejimo_budai()
        {
            return View();
        }

        public ActionResult registruoti_irengini()
        {
            return View();
        }
        public ActionResult irenginio_ataskaita()
        {
            return View();
        }
        public ActionResult kliento_informacija()
        {
            return View();
        }
        public ActionResult gedimu_istorija()
        {
            return View();
        }
        public ActionResult About() {
            return View();
        }

        public ActionResult prekiu_sarasas()
        {
            return View();
        }
        public ActionResult saskaitu_sarasas()
        {
            return View();
        }
        public ActionResult preke_keitimas()
        {
            return View();
        }
        public ActionResult preke_nauja()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IS_CS.Models;
namespace IS_CS.Controllers
{
    public class prekeController : Controller
    {
        // GET: preke
        public ActionResult Index()
        {
            var entities = new prekeContext();

            return View(entities.prekes.ToList());
        }

    }
}
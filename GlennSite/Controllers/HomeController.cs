using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectronicDetective;

namespace GlennSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // test to see if updates git
            return View();
        }

        public ActionResult ElectronicDetective()
        {
            return View();
        }
    }
}
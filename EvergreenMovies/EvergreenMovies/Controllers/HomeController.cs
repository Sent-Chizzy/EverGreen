using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvergreenMovies.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Movies()
        {
            ViewBag.Message = "Your movies  page.";

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

        public ActionResult WriteForUs()
        {
            ViewBag.Message = "Fill for to write for us";

            return View();
        }

        public ActionResult Requestforlink()
        {
            ViewBag.Message = "Fill the form to get a torrent download link";

            return View();
        }
    }
}
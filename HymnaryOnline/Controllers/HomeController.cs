using HymnaryOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HymnaryOnline.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Inicio";
            return View();
        }

        public ActionResult Projector()
        {
            return View();
        }

        public ActionResult Lyrics(int? id)
        {
            return View();
        }

        public ActionResult Clarinet()
        {
            return View();
        }

        public ActionResult Violin()
        {
            return View();
        }

        public ActionResult Guitar()
        {
            return View();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Paub2022_Vjezba.Controllers
{
    public class mojprviController : Controller
    {
        // GET: mojprvi
        public ActionResult Index()
        {
            ViewBag.Lokacija = "Međimursko veleučilište u Čakovcu";
            return View();
        }
        public ActionResult Druga()
        {
            ViewBag.Ustanova = "Međimursko veleučilište";
            ViewData["Lokacija"] = "Čakovec";
            return View();
        }
        public ActionResult Treca(string poruka, int broj=1)
        {
            ViewBag.Poruka = poruka;
            ViewBag.Broj = broj;
            return View();
        }
        public ActionResult Student()
        {
            ViewBag.Ime = "Sonja";
            ViewBag.Prezime = "Prezime";
            ViewBag.GodinaRodenja = "2000";
            return View();
        }

        public string VratiVrijeme()
        {
            return DateTime.Now.ToString();
        }
    }
}
using Paub2022_Vjezba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Paub2022_Vjezba.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Title = "Početna o studentima";
            ViewBag.Fakultet = "Međimursko veleučilište";
            return View();
        }
        public ActionResult Popis()
        {
            StudentiDB studentDB = new StudentiDB();
            return View(studentDB);

        }
        public ActionResult Detalji(int? id)
        {
            if (!id.HasValue)
                RedirectToAction("Popis");
            StudentiDB studentDB = new StudentiDB();
            Student student = studentDB.VratiListu().FirstOrDefault(x => x.ID == id);
            if(student==null)
            {
                return HttpNotFound();
            }

            return View(student);
        }
        [HttpPost]
        [ValidateAntiForgeryToken] //mehanizam koji nas štiti od cross site request
                                   // forgery  (poziva post metode izvan naše aplikacije)
        public ActionResult Azuriraj(Student s)
        { if(!OIB.CheckOIB(s.Oib))
            {
                ModelState.AddModelError("Oib", "Neispravan OIB");
            }
        if(DateTime.Now.Year-s.DatumRodjenja.Year<18)
                    {
                ModelState.AddModelError("Nije stariji od 18","stariji je od 18");
            }
                    

            if (ModelState.IsValid)
            {
                //Ažuriranje liste podataka
                StudentiDB studentidb = new StudentiDB();
                studentidb.AzurirajStudenta(s);
                //Preusmjeravanje na metodu koja vraća popis studenata
                return RedirectToAction("Popis");
            }
            //Ako model nije ispravan vraćamo ga klijentu
            return View(s);
        }
    }
}
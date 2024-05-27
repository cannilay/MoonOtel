using MoonOtel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MoonOtel.Controllers
{
    public class PersonelController : Controller
    {
        MoonOtelContext db=new MoonOtelContext();
        // GET: Personel
        public ActionResult Personel()
        {
            MoonOtelContext db = new MoonOtelContext();
            List<Personel> personel = db.Personel.ToList();
            return View(personel);
        }
        [HttpGet]
        public ActionResult YeniPersonel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniPersonel(Personel p)
        {
            MoonOtelContext db = new MoonOtelContext();
            db.Personel.Add(p);
            db.SaveChanges();
            return RedirectToAction("Personel");
        }
        public ActionResult Duzenle(int id)
        {
            MoonOtelContext db = new MoonOtelContext();
            var personel = db.Personel.Find(id);
            return View("Duzenle", personel);

        }
        [HttpPost]
        public ActionResult Guncelle(Personel p)
        {
            MoonOtelContext db = new MoonOtelContext();
            var personel = db.Personel.Find(p.personelD);
            personel.ad = p.ad;
            personel.soyad = p.soyad;
            personel.cinsiyet = p.cinsiyet;
            personel.telefon = p.telefon;
            personel.eposta = p.eposta;
            db.SaveChanges();
            return RedirectToAction("Personel");
        }
    }
}

using MoonOtel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoonOtel.Controllers
{
    public class RezerveController : Controller
    {
        public ActionResult MusteriRezerve()
        {
            MoonOtelContext db = new MoonOtelContext();
            List<MusteriKayit> musteri = db.MusteriKayit.ToList();
            return View();
        }

        [HttpGet]
        public ActionResult YeniMusteriRezerve()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniMusteriRezerve(MusteriKayit m)
        {
            MoonOtelContext db = new MoonOtelContext();

            // odaID değeri veritabanında başka bir kayıtta kullanılıyor mu kontrol et
            bool odaIDKullanimda = db.MusteriKayit.Any(x => x.odaID == m.odaID);

            if (odaIDKullanimda)
            {
                TempData["HataMesaji"] = "Bu oda zaten kullanılıyor.";
                return RedirectToAction("YeniMusteriRezerve"); // Aynı sayfaya geri dön
            }

            db.MusteriKayit.Add(m);
            db.SaveChanges();
            return RedirectToAction("Musteri");
        }

    }
}
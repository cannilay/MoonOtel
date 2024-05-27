using MoonOtel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoonOtel.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        public ActionResult Musteri()
        {
            MoonOtelContext db = new MoonOtelContext();
            List<MusteriKayit> musteri = db.MusteriKayit.ToList();
            return View(musteri);
        }

        [HttpGet]
        public ActionResult YeniMusteri()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniMusteri(MusteriKayit m)
        {
            MoonOtelContext db = new MoonOtelContext();

            bool odaIDKullanimda = db.MusteriKayit.Any(x => x.odaID == m.odaID);

            if (odaIDKullanimda)
            {
                TempData["HataMesaji"] = "Bu oda zaten kullanılıyor.";
                return RedirectToAction("YeniMusteri"); 
            }

            db.MusteriKayit.Add(m);
            db.SaveChanges();
            return RedirectToAction("Musteri");
        }

        public ActionResult Sil(int id)
        {
            MoonOtelContext db = new MoonOtelContext();
            var musteri = db.MusteriKayit.Find(id);
            db.MusteriKayit.Remove(musteri);
            db.SaveChanges();
            return RedirectToAction("Musteri");
        }
        public ActionResult Duzenle(int id)
        {
            MoonOtelContext db = new MoonOtelContext();
            var musteri = db.MusteriKayit.Find(id);
            return View("Duzenle", musteri);

        }
        [HttpPost]
        public ActionResult Guncelle(MusteriKayit m)
        {
            MoonOtelContext db = new MoonOtelContext();
            var musteri = db.MusteriKayit.Find(m.musteriID);
            musteri.ad = m.ad;
            musteri.soyad = m.soyad;    
            musteri.cinsiyet = m.cinsiyet;  
            musteri.adres = m.adres;    
            musteri.telefon = m.telefon;    
            musteri.eposta  = m.eposta;
            musteri.Oda = m.Oda;    
            musteri.kisiSayisi  = m.kisiSayisi; 
            musteri.girisTarihi = m.girisTarihi;    
            musteri.cikisTarihi = m.cikisTarihi;    
            db.SaveChanges();   
            return RedirectToAction("Musteri");   
        }
    }
}
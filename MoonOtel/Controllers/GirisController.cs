using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MoonOtel.Controllers;
using MoonOtel.Models;

namespace MoonOtel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string eposta, string sifre)
        {
            MoonOtelContext db = new MoonOtelContext();
            Personel personel = db.Personel.Where(x => x.eposta == eposta && x.sifre == sifre).SingleOrDefault();
            if (personel == null) // yoksa
            {
                ViewBag.sonuc = "Personel bulunamadı.";
                return View();
            }
            else
            {
                Session["Personel"] = personel;
                return RedirectToAction("Anasayfa");
            }

        }

        public ActionResult Anasayfa()
        {
            return View();
        }

        //public ActionResult Cikis()
        //{
        //    System.Web.Security.FormsAuthentication.SignOut();
        //    Response.Cache.SetCacheability(HttpCacheability.NoCache);
        //    Response.Cache.SetNoStore();
        //    if (Session != null)
        //    {
        //        Session.Abandon();
        //    }

        //    // Kullanıcıyı çıkış işlemi sonrasında başka bir sayfaya yönlendirin
        //    return RedirectToAction("Home");
        //}




    }
}
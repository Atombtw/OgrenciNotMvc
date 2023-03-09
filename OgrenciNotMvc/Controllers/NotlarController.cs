using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvc.Models.Entity;
using OgrenciNotMvc.Models;

namespace OgrenciNotMvc.Controllers
{
    public class NotlarController : Controller
    {
        // GET: Notlar
        DbMvcOkulEntities db = new DbMvcOkulEntities();
        public ActionResult Index()
        {
            var t = db.Tbl_Notlar.ToList();
            return View(t);
        }

        [HttpGet]
        public ActionResult NotEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NotEkle(Tbl_Notlar p)
        {
            db.Tbl_Notlar.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Güncelle(int id)
        {
            var t = db.Tbl_Notlar.Find(id);
            return View(t);
        }

        [HttpPost]
        public ActionResult Güncelle(Hesapla model, Tbl_Notlar p, int sinav1 = 0, int sinav2 = 0, int sinav3 = 0 , int proje = 0)
        {
            if (model.Islem == "Hesapla")
            {
                double sonuc = (sinav1 + sinav2 + sinav3 + proje) / 4;
                ViewBag.ort = sonuc;
            }
            if (model.Islem == "Güncelle")
            {
                var t = db.Tbl_Notlar.Find(p.NotID);
                t.Sinav1 = p.Sinav1;
                t.Sinav2 = p.Sinav2;
                t.Sinav3 = p.Sinav3;
                t.Proje = p.Proje;
                t.Ortalama = p.Ortalama;
                t.Durum = p.Durum;
                db.SaveChanges();
                return RedirectToAction("Index", "Notlar");
            }   
            return View();
        }
    }
}
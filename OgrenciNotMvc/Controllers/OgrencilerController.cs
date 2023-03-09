using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvc.Models.Entity;

namespace OgrenciNotMvc.Controllers
{
    public class OgrencilerController : Controller
    {
        // GET: Ogrenciler
        DbMvcOkulEntities db = new DbMvcOkulEntities();
        public ActionResult Index()
        {
            var t = db.Tbl_Ogrenciler.ToList();
            return View(t);
        }

        [HttpGet]
        public ActionResult OgrenciEkle()
        {
            List<SelectListItem> t = (from i in db.Tbl_Kulüpler.ToList()
                                      select new SelectListItem
                                      {
                                          Text = i.KulüpAd,
                                          Value = i.KulüpID.ToString()
                                      }).ToList();
            ViewBag.dgr = t;
            return View();
        }

        [HttpPost]
        public ActionResult OgrenciEkle(Tbl_Ogrenciler p)
        {
            var t = db.Tbl_Kulüpler.Where(i => i.KulüpID == p.Tbl_Kulüpler.KulüpID).FirstOrDefault();
            p.Tbl_Kulüpler = t;
            db.Tbl_Ogrenciler.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var t = db.Tbl_Ogrenciler.Find(id);
            db.Tbl_Ogrenciler.Remove(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Güncelle(int id)
        {
            List<SelectListItem> x = (from i in db.Tbl_Kulüpler.ToList()
                                      select new SelectListItem
                                      {
                                          Text = i.KulüpAd,
                                          Value = i.KulüpID.ToString()
                                      }).ToList();
            ViewBag.dgr = x;
            var t = db.Tbl_Ogrenciler.Find(id);
            return View(t);
        }

        [HttpPost]
        public ActionResult Güncelle(Tbl_Ogrenciler p)
        {
            var x = db.Tbl_Kulüpler.Where(i => i.KulüpID == p.Tbl_Kulüpler.KulüpID).FirstOrDefault();
            var t = db.Tbl_Ogrenciler.Find(p.OgrenciID);
            t.Tbl_Kulüpler = x;
            t.OgrenciAd = p.OgrenciAd;
            t.OgrenciSoyad = p.OgrenciSoyad;
            t.OgrenciFotograf = p.OgrenciFotograf;
            t.OgrenciCinsiyet = p.OgrenciCinsiyet;
            db.SaveChanges();
            return RedirectToAction("Index", "Ogrenciler");
        }
    }
}
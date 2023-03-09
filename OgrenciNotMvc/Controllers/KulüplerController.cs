using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvc.Models.Entity;

namespace OgrenciNotMvc.Controllers
{
    public class KulüplerController : Controller
    {
        // GET: Kulüpler
        DbMvcOkulEntities db = new DbMvcOkulEntities();
        public ActionResult Index()
        {
            var t = db.Tbl_Kulüpler.ToList();
            return View(t);
        }

        [HttpGet]
        public ActionResult KulüpEkle() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult KulüpEkle(Tbl_Kulüpler p)
        {
            db.Tbl_Kulüpler.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var t = db.Tbl_Kulüpler.Find(id);
            db.Tbl_Kulüpler.Remove(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Güncelle(int id)
        {
            var t = db.Tbl_Kulüpler.Find(id);
            return View(t);
        }

        [HttpPost]
        public ActionResult Güncelle(Tbl_Kulüpler p)
        {
            var t = db.Tbl_Kulüpler.Find(p.KulüpID);
            t.KulüpAd = p.KulüpAd;
            t.KulüpKontenjan = p.KulüpKontenjan;
            db.SaveChanges();
            return RedirectToAction("Index", "Kulüpler");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvc.Models.Entity;

namespace OgrenciNotMvc.Controllers
{
    public class DerslerController : Controller
    {
        // GET: Dersler
        DbMvcOkulEntities db = new DbMvcOkulEntities();
        public ActionResult Index()
        {
            var t = db.Tbl_Dersler.ToList();
            return View(t);
        }

        [HttpGet]
        public ActionResult DersEkle() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult DersEkle(Tbl_Dersler p)
        {
            db.Tbl_Dersler.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var t = db.Tbl_Dersler.Find(id);
            db.Tbl_Dersler.Remove(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Güncelle(int id)
        {
            var t = db.Tbl_Dersler.Find(id);
            return View(t);
        }

        [HttpPost]
        public ActionResult Güncelle(Tbl_Dersler p)
        {
            var t = db.Tbl_Dersler.Find(p.DersID);
            t.DersAd = p.DersAd;
            db.SaveChanges();
            return RedirectToAction("Index", "Dersler");
        }
    }
}
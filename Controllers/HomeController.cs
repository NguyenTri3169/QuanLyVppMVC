using QuanLyVppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyVppMVC.Controllers
{
    public class HomeController : Controller
    {
        QLTVEntities1 db = new QLTVEntities1();
        public ActionResult Index()
        {
            List<SACH> ds = db.SACHes.ToList();
            return View(ds);
        }
        public ActionResult themButton()
        {
            return View();
        }
        [HttpPost]
        public ActionResult themButton(SACH s)
        {
            SACH s1 = db.SACHes.Find(s.Ma_Sach);
            if (s1 != null)
            {
                return Content("Trùng Mã");
            }
            else
            {
                db.SACHes.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

        }
        public ActionResult xoaDS(string id)
        {
            SACH s1 = db.SACHes.Find(id);
            db.SACHes.Remove(s1);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult suaDS(string id)
        {
            SACH s = db.SACHes.Find(id);
            return View(s);

        }

        [HttpPost]
        public ActionResult suaDS(SACH s)
        {
            db.Entry(s).State=System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
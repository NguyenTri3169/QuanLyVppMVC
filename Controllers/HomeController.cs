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
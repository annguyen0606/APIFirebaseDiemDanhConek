using DatabaseIO;
using DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirebaseASPAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DBIO db = new DBIO();
            TimKiemThongTinKHTheoBienSo timKiemThongTinKHTheoBien = db.GetThongTinKHTheoBienSo("99G1-14313", 92); 
            return View(timKiemThongTinKHTheoBien);
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
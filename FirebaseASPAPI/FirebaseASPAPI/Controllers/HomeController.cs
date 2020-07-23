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
        public ActionResult Index(String bienSo, int IdCongTy)
        {
            DBIO db = new DBIO();
            KhachHang timKiemThongTinKHTheoBien = db.GetThongTinKHTheoBienSo(bienSo, IdCongTy); 
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
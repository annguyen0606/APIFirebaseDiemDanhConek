using FirebaseASPAPI.Models;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FirebaseASPAPI.Controllers
{
    public class SetDataRealTimeController : Controller
    {
        // GET: SetDataRealTime
        String pathDuLieuDiemDanh = "Conek/DuLieuDiemDanh/";
        String pathDanhSachNhanVien = "Conek/DanhSachNhanVien/";
        //String pathServer = "https://annguyenhoctap.firebaseio.com/";
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "",
            BasePath = "https://annguyenhoctap.firebaseio.com/"
        };

        IFirebaseClient client;
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> SetDataFirebase(string uidTag ,string thoiGian, string soPhutMuon)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                PushResponse response = client.Push(pathDuLieuDiemDanh + uidTag+"/"+DateTime.Now.ToString("yyyy-MM-dd"), thoiGian + ","+soPhutMuon);
                if (String.IsNullOrEmpty(response.Result.name.ToString()))
                {
                    ViewBag.UIDTag = "INSERT FAILED";
                }
                else
                {
                    ViewBag.UIDTag = response.Result.name.ToString();
                }
            }
            else
            {
                ViewBag.UIDTag = "CONNECT FAILED";
            }
            
            //string statusQuery = "";
            //var cde = this.ControllerContext.RouteData.Values["Tag"];
            //uidTag = cde.ToString();
            
            return View();
        }
    }
}
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
        String pathActiveSim = "ActiveSim/Active/";
        //String pathServer = "https://annguyenhoctap.firebaseio.com/";
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "XYcRpajciWgqrcQNUWovKfSOEUTUFv5hgkyGEvnI",
            //BasePath = "https://annguyenhoctap.firebaseio.com/"
            BasePath = "https://cloud-nfc-proj.firebaseio.com/"
        };

        IFirebaseClient client;
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> SetDataFirebase(string uidTag)
        {
            DateTimeOffset dateTimeOffset = new DateTimeOffset(DateTime.Now);
            DateTimeOffset gioCurrent = dateTimeOffset.ToOffset(TimeSpan.FromHours(7));

            string soPhutMuon = "";
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                if(int.Parse(gioCurrent.ToString("HH")) >= 8 && int.Parse(gioCurrent.ToString("HH")) < 12)
                {
                    soPhutMuon = Convert.ToString((int.Parse(gioCurrent.ToString("HH")) * 60 + int.Parse(gioCurrent.ToString("mm"))) - (8*60 + 30));
                }else if (int.Parse(gioCurrent.ToString("HH")) >= 13 && int.Parse(gioCurrent.ToString("HH")) < 18)
                {
                    soPhutMuon = Convert.ToString((int.Parse(gioCurrent.ToString("HH")) * 60 + int.Parse(gioCurrent.ToString("mm"))) - (13 * 60 + 30));
                }
                else
                {
                    soPhutMuon = "0";
                }
                PushResponse response = client.Push(pathDuLieuDiemDanh + uidTag+"/"+ gioCurrent.ToString("yyyy-MM-dd"), gioCurrent.ToString("HH:mm:ss") + ","+soPhutMuon);
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

        public async Task<ActionResult> ActiveSim()
        {
            DateTimeOffset dateTimeOffset = new DateTimeOffset(DateTime.Now);
            DateTimeOffset gioCurrent = dateTimeOffset.ToOffset(TimeSpan.FromHours(7));

            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                SetResponse response = client.Set(pathActiveSim, gioCurrent.ToString("dd-MM-yyyy HH:mm:ss"));
                string[] resultRes = response.Body.Split('"');
                if(resultRes[1].Trim().Equals(gioCurrent.ToString("dd-MM-yyyy HH:mm:ss")))
                {
                    ViewBag.Request = resultRes[1];
                }
                else
                {
                    ViewBag.Request = "Active Failed";
                }
            }
            else
            {
                ViewBag.Request = "CONNECT FAILED";
            }
            return View();
        }
    }
}
using FirebaseASPAPI.Models;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using NFCIO;
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
        String pathKindergartenTakePupil = "MamNon/DuLieuDonHocSinh/";
        String pathKindergartenGetMoney = "MamNon/DuLieuNopTien/";
        String pathDuLieuDiemDanh = "Conek/DuLieuDiemDanh/";
        String pathDanhSachNhanVien = "Conek/DanhSachNhanVien/";
        String pathActiveSim = "ActiveSim/Active/";
        String pathDuLieuTest = "DulieuTest/";
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
                    ViewBag.Request = "Success";
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

        public async Task<ActionResult> DuLieuTest(string uidTag, string money)
        {
            DateTimeOffset dateTimeOffset = new DateTimeOffset(DateTime.Now);
            DateTimeOffset gioCurrent = dateTimeOffset.ToOffset(TimeSpan.FromHours(7));

            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                PushResponse response = client.Push(pathDuLieuTest + uidTag + "/" + gioCurrent.ToString("yyyy-MM-dd"), gioCurrent.ToString("HH:mm:ss") + "," + money);
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
            return View();
        }

        public async Task<ActionResult> KindergartenTakePupil(string uidTag, string lop)
        {
            DateTimeOffset dateTimeOffset = new DateTimeOffset(DateTime.Now);
            DateTimeOffset gioCurrent = dateTimeOffset.ToOffset(TimeSpan.FromHours(7));

            string soPhutMuon = "";
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                if (int.Parse(gioCurrent.ToString("HH")) >= 8 && int.Parse(gioCurrent.ToString("HH")) < 12)
                {
                    soPhutMuon = Convert.ToString((int.Parse(gioCurrent.ToString("HH")) * 60 + int.Parse(gioCurrent.ToString("mm"))) - (8 * 60 + 30));
                }
                else if (int.Parse(gioCurrent.ToString("HH")) >= 13 && int.Parse(gioCurrent.ToString("HH")) < 18)
                {
                    soPhutMuon = Convert.ToString((int.Parse(gioCurrent.ToString("HH")) * 60 + int.Parse(gioCurrent.ToString("mm"))) - (13 * 60 + 30));
                }
                else
                {
                    soPhutMuon = "0";
                }
                SetResponse response = client.Set(pathKindergartenTakePupil + lop + "/" + gioCurrent.ToString("yyyy-MM-dd") + "/" + uidTag, gioCurrent.ToString("HH:mm:ss") + "," + soPhutMuon);
                string[] resultRes = response.Body.Split('"');
                if (resultRes[1].Trim().Equals(gioCurrent.ToString("HH:mm:ss") + "," + soPhutMuon))
                {
                    ViewBag.Request = "Success";
                }
                else
                {
                    ViewBag.Request = "ActiveFailed";
                }
            }
            else
            {
                ViewBag.UIDTag = "CONNECTFAILED";
            }
            return View(ViewBag);
        }

        public async Task<ActionResult> GetMoney(string uidTag, string lop, string money, string magv)
        {
            DateTimeOffset dateTimeOffset = new DateTimeOffset(DateTime.Now);
            DateTimeOffset gioCurrent = dateTimeOffset.ToOffset(TimeSpan.FromHours(7));
            NFCDBIO db = new NFCDBIO();
            int i = db.InsertNopTien(uidTag, lop, gioCurrent.ToString("yyyy-MM"),money,magv);
            ViewBag.Request = i.ToString();
            if (i == 1)
            {
                client = new FireSharp.FirebaseClient(config);
                if (client != null)
                {
                    SetResponse response = client.Set(pathKindergartenGetMoney + lop + "/" + gioCurrent.ToString("yyyy-MM") + "/" + uidTag, gioCurrent.ToString("HH:mm:ss yyyy-MM-dd"));
                    string[] resultRes = response.Body.Split('"');
                    if (resultRes[1].Trim().Equals(gioCurrent.ToString("HH:mm:ss yyyy-MM-dd")))
                    {
                        ViewBag.Request = "Success";
                    }
                    else
                    {
                        ViewBag.Request = "ActiveFailed";
                    }
                }
                else
                {
                    ViewBag.UIDTag = "CONNECTFAILED";
                }
            }else if(i == 2)
            {
                client = new FireSharp.FirebaseClient(config);
                if (client != null)
                {
                    SetResponse response = client.Set(pathKindergartenGetMoney + lop + "/" + gioCurrent.ToString("yyyy-MM") + "/" + uidTag, gioCurrent.ToString("HH:mm:ss yyyy-MM-dd"));
                    string[] resultRes = response.Body.Split('"');
                    if (resultRes[1].Trim().Equals(gioCurrent.ToString("HH:mm:ss yyyy-MM-dd")))
                    {
                        ViewBag.Request = "Dontenoughmoney";
                    }
                    else
                    {
                        ViewBag.Request = "ActiveFailed";
                    }
                }
                else
                {
                    ViewBag.UIDTag = "CONNECTFAILED";
                }
            }
            else
            {
                ViewBag.Request = "HaventData";
            }
            return View(ViewBag);
        }
    }
}
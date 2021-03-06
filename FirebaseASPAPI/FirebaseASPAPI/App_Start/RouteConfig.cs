﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FirebaseASPAPI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            routes.MapRoute("API Firebase", "conek/dulieudiemdanh", new { controller = "SetDataRealTime", action = "SetDataFirebase"});
            routes.MapRoute("API Active Sim", "conek/activesim", new { Controller = "SetDataRealTime", action = "ActiveSim" });
            routes.MapRoute("API Test", "conek/dulieutest", new { Controller = "SetDataRealTime", action = "DuLieuTest" });
            routes.MapRoute("AutoCare getInforCustomer", "conek/Autocare/LayThongTinKhach", new { Controller = "SetDataRealTime", action = "GetInforCustomer" });
            routes.MapRoute("KinderGarten Take Pupil","conek/kindergarten/takepupil",new { Controller = "SetDataRealTime", action = "KindergartenTakePupil" });
            routes.MapRoute("KinderGarten Receive Money", "conek/kindergarten/getmoney", new { Controller = "SetDataRealTime", action = "GetMoney" });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            
        }
    }
}

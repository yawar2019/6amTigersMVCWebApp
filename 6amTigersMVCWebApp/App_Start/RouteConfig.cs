using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _6amTigersMVCWebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes(); 

            routes.MapRoute(
                name: "xyz",
                url: "IPLWinner/Titan",
                defaults: new { controller = "new", action = "SampleMethod2", eid = UrlParameter.Optional }
            );


            routes.MapRoute(
               name: "pqr",
               url: "IPLRunnerUp/Royals",
               defaults: new { controller = "new", action = "SampleMethod2", eid = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{eid}",
                defaults: new { controller = "Home", action = "Index", eid = UrlParameter.Optional }
            );

        }
    }
}

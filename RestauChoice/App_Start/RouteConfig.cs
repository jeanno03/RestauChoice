using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RestauChoice
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "VoirResto",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "VoirResto", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "GetTest",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "GetTest", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Index02",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index02", id = UrlParameter.Optional }
            );

        }
    }
}

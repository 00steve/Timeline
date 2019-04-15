using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TimelineApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Timeline",
                url: "Timeline/{id}",
                defaults: new { controller = "Timeline", action = "Timeline" }
            );

            routes.MapRoute(
                name: "MyTimelines",
                url:"Mytimelines",
                defaults : new { controller = "Timeline", action = "Index" }
            );


            //some garbage default shit
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}

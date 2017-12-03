using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Random",
                url: "Movie/RandomMovie/{moviename}/{ReleaseYear}",
                defaults: new { controller = "Movie", action = "RandomMovie", moviename = "ABCD2", ReleaseYear = "2015" }
                //constraints: new { ReleaseYear = @"\d{4}" }
                // namespace= "MVC1.Controllers")
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

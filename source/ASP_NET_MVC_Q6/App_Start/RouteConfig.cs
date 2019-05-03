﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP_NET_MVC_Q6
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Contact",
                url: "Contact",
                defaults: new { controller = "Home", action = "ContactMe" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{action}",
                defaults: new { controller = "Default", action = "Login"},
                namespaces: new[] { "ASP_NET_MVC_Q6.Controllers" }
            );
            routes.MapRoute(
                name: "DefaultControllerAction",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "ASP_NET_MVC_Q6.Controllers" }
            );

        }
    }
}

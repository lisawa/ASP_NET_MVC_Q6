using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP_NET_MVC_Q6.Filter
{
    public class ActionFilter : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string route = "";
            if (filterContext.RouteData.DataTokens["area"] != null)
                route += "area = " + filterContext.RouteData.DataTokens["area"].ToString() + ", ";
            if (filterContext.RouteData.Values["controller"] != null)
                route += "controller = " + filterContext.RouteData.Values["controller"].ToString() + ", ";
            if (filterContext.RouteData.Values["action"] != null)
                route += "action = " + filterContext.RouteData.Values["action"].ToString();
            if (filterContext.RouteData.Values["id"] != null)
                route += ", " + filterContext.RouteData.Values["id"].ToString() + " = 數字";
            if (filterContext.RouteData.Values["page"] != null)
                route += ", " + filterContext.RouteData.Values["page"].ToString() + " = 數字";
            if (filterContext.RouteData.Values["category"] != null)
                route += ", " + filterContext.RouteData.Values["category"].ToString() + " = 字串";
            filterContext.Controller.ViewData["Route"] = route.Trim(new char[] { ',', ' ' });
            filterContext.Controller.ViewData["Title"] = filterContext.RouteData.Values["action"].ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_Q6.Filter;

namespace ASP_NET_MVC_Q6.Controllers
{
    [ActionFilter]
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            var m = RouteData.Values;
            return View();
        }

        public ActionResult List()
        {
            return View("Login");
        }

    }
}
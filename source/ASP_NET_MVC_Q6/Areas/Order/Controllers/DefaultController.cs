using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_Q6.Filter;

namespace ASP_NET_MVC_Q6.Areas.Order.Controllers
{
    [ActionFilter]
    public class DefaultController : Controller
    { 
        public ActionResult List()
        {
            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }
    }
}
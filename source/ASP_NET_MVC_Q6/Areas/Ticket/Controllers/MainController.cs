using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_Q6.Filter;

namespace ASP_NET_MVC_Q6.Areas.Ticket.Controllers
{
    [ActionFilter]
    public class MainController : Controller
    {
        // GET: Ticket/Main
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
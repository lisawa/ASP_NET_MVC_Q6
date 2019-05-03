﻿using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Areas.Ticket
{
    public class TicketAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Ticket";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Ticket_default",
                "Ticket/{action}/{id}",
                new { controller = "Main", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
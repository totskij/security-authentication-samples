﻿using System.Web.Mvc;
using System.Web.Routing;

namespace CollectorBank.Security.Authentication.Samples.OpenIDConnectWebClientOwin
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
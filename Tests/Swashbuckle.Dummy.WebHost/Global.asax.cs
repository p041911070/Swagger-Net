﻿using System.Web;
using System.Web.Http;

namespace Swagger.Net.Dummy.WebHost
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            SwaggerConfig.Register(GlobalConfiguration.Configuration);            
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
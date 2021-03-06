using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace StrikersInfy.Feature.Translator.Pipelines
{
    public class RegisterRoutes
    {
        public void Process(PipelineArgs args)
        {
            HttpConfiguration config = GlobalConfiguration.Configuration;

            Register(config);
        }

        public static void Register(HttpConfiguration config)
        {
            //config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "TranslatorApi",
                routeTemplate: "api/Translator/{action}",
                new { controller = "Translator" }
            );           
        }
    }
}
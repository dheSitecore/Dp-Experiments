using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DP.Sitecore.Experiments.Routes
{
    public class RegisterMvcEndpointRoutes
    {
        public void Process(PipelineArgs args)
        {

            //examples for mvc routes
            RouteTable.Routes.MapRoute(
                name: "dp.mvc.api.test.one",
                url: "api/dp-mvc-endpoint-test/{action}",
                defaults: new { controller = "MvcEndpoint" });

        }
    }
}
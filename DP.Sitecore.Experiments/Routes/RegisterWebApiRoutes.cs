using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace DP.Sitecore.Experiments.Routes
{
    public class RegisterWebApiRoutes
    {
        //example for SSC routes
        //Default route of ssc takes this /sitecore/api/ssc/namespace-to-controller/{controller}/{id}/{action} (only if decorate your controller with this [ServicesController])

        public void Process(PipelineArgs args)
        {
            var config = GlobalConfiguration.Configuration;

            config.Routes.MapHttpRoute(
              name: "dp.services.api.test.one",
              routeTemplate: "sitecore/api/dp-services-api/{action}",
              defaults: new { controller = "ServicesApiTest" });
        }
    }
    //public virtual void Process(PipelineArgs args)
    //{
    //    RouteTable.Routes.MapRoute("dp.services.api.test.one", "sitecore/api/dp-services-api/{action}", new { controller = "ServicesApiTest" });
    //}
}
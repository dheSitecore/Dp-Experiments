using Newtonsoft.Json;
using Sitecore.Services.Core;
using Sitecore.Services.Infrastructure.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using Sitecore.Mvc.Controllers;
using System.Web.Mvc;

namespace DP.Sitecore.Experiments.Controllers
{
    public class MvcEndpointController : SitecoreController
    {
        //api/dp-mvc-endpoint-test/Get?id=1
        public ActionResult Get(string id)
        {
            return Json($"hello world from 'Get' of id {id}", "application/json", Encoding.UTF8, JsonRequestBehavior.AllowGet);
        }

        //api/dp-mvc-endpoint-test/Test
        public ActionResult Test()
        {
            return Json("hello world from 'Test'", "application/json", Encoding.UTF8, JsonRequestBehavior.AllowGet);
        }

        //api/dp-mvc-endpoint-test/TestParams?id=1&value=2
        public ActionResult TestParams(string id, string value)
        {
            return Json($"hello world from 'Get' and the id is {id} and value is {value}", "application/json", Encoding.UTF8, JsonRequestBehavior.AllowGet);
        }
    }
}
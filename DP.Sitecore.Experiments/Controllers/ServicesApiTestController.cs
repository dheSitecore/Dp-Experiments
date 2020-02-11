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

namespace DP.Sitecore.Experiments.Controllers
{
    //[ServicesController] //only needed for default sitecore routes
    public class ServicesApiTestController : ServicesApiController
    {
        [HttpGet]
        [ActionName("Get")]
        //sitecore/api/dp-services-api/get?id=1
        public IHttpActionResult Get(string id)
        {
            return new JsonResult<string>($"hello world from 'Get' and the id is {id}", new JsonSerializerSettings(), Encoding.UTF8, this);
        }

        [HttpGet]
        [ActionName("Test")]
        //sitecore/api/dp-services-api/test
        public IHttpActionResult Test()
        {
            return new JsonResult<string>($"hello world from 'Test'", new JsonSerializerSettings(), Encoding.UTF8, this);
        }


        [HttpGet]
        [ActionName("TestParams")]
        ///sitecore/api/dp-services-api/testparams?id=1&value=2
        public IHttpActionResult TestParams(string id, string value)
        {
            return new JsonResult<string>($"hello world from 'Get' and the id is {id} and value is {value}", new JsonSerializerSettings(), Encoding.UTF8, this);
        }
    }
}
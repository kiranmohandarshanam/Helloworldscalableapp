using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sample.Data;
using Sample.Data.Interface;

namespace SampleHelloWebApi.Controllers
{
    public class SampleDataController : ApiController
    {

        public IHttpActionResult Get()
        {
            IDataService dataServiceObj = new DataService();
            return Ok(dataServiceObj.getData());
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleHelloWebApi.Controllers;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Results;
using System.Net;

namespace sampleappunittest
{
    [TestClass]
    public class SampleDataControllerTest
    {
        [TestMethod]
        public void GetData()
        {
            var controller = new SampleDataController();
            IHttpActionResult actionResult = controller.Get();
            var negResult = actionResult as OkNegotiatedContentResult<string>;
            Assert.IsNotNull(negResult);          
            Assert.AreEqual("Hello World", negResult.Content.ToString());
        }
    }
}

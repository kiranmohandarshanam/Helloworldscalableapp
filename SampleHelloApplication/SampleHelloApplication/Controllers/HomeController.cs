using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace samplehelloweb12.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.Title = "Home Page";
            ViewBag.Message = "Loading...";
           
            using (var client = new HttpClient())
            {
                string apiurl = System.Configuration.ConfigurationManager.AppSettings.Get("apiBaseUrl");
                client.BaseAddress = new Uri(apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("api/SampleData/").Result;
                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Message = response.Content.ReadAsStringAsync().Result;
                }
            }
            return View();
        }

       

       
    }
}
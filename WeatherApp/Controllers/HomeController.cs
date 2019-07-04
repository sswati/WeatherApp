using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WeatherApp.Models;


namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var client = new RestClient("https://api.darksky.net/forecast/7857177b0392a79d68bd0820b76714dc/51.50642,-0.12721");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            string responseBody = response.Content;
            var forecast = JsonConvert.DeserializeObject<Forecast>(responseBody);

            var forcastData = forecast.Daily.Data.ToList();

            return View(forcastData);
            
        }

    }
}

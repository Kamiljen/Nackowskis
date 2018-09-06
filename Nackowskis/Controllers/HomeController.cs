using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nackowskis.Models;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Nackowskis.Controllers
{
    public class HomeController : Controller
    {
        public string BaseAdress = "http://nackowskis.azurewebsites.net/api/";
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult GetAllAuctions(int groupNmbr)
        //{

        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(BaseAdress + "Auktion/" + groupNmbr.ToString());
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new
        //        MediaTypeWithQualityHeaderValue("application/json"));
        //        //Anropar get metoden i controllern som heter Default
        //        HttpResponseMessage response =
        //        client.GetAsync("/api/Default").Result;
        //        //Kastar ett fel om svaret innehåller en felkod.
        //        response.EnsureSuccessStatusCode();
        //        //Ta emot ett svar och serialisera det (nästa ste
        //    }
        //}

            public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

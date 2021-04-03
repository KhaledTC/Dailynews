using Dailynews.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dailynews.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public async Task<IActionResult> Index()
        {
            List<News> model = new List<News>();
            for (int i = 1; i <= 3; i++)
            {
                string agency = "ag" + i.ToString();
                string JsonFileName = agency + ".json";
                StreamReader r = new StreamReader("Jsons/" + JsonFileName);
                string jsonContent = r.ReadToEnd();
                News news = JsonConvert.DeserializeObject<News>(jsonContent);
                foreach (var n in news.latestnews)
                    n.source = agency;
                model.Add(news);
            }
            return View(model);
        }
    }
}

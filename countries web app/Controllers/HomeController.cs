using countries_web_app.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace countries_web_app.Controllers
{
    public class HomeController : Controller
    {
        List<Country> CountryList = new List<Country>
        {
            new Country("Kenya", "this is the kenya language", "hello world greeting", "description of kenya", "black, red, green"),
            new Country("Jamaica", "this is the jamaica language", "hello world greeting", "description of jamaica", "green, yellow, black"),
            new Country("Colombia", "this is the colombia language", "hello world greeting", "description of colombia", "yellow, blue, red"),
            };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CountryDetails()
        {
            return View();
        }

        public IActionResult Countries()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Countries(string country)
        {
            HttpContext.Session.SetString("countrydescription", country);
            ViewBag.sess = HttpContext.Session.GetString("countrydescription");
            //Country c = CountryList[index];
            return View();
        }
        [HttpPost]
        public IActionResult CountrySelection(string country)
        {
            return View();
        }
        public IActionResult CountryDescription()
        {
            return View();
        }
        public IActionResult Privacy()
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

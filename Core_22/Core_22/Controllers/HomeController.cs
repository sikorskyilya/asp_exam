using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core_22.Models;
using Microsoft.Extensions.Logging;

namespace Core_22.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger logger;

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        [Route("")]
        [Route("Home/Index")]
        [Route("Index")]
        [Route("Default")]
        [Route("0")]
        public IActionResult Index()
        {
            ViewBag.Header = "Страны";
            ViewBag.Countries = new List<string> { "Беларусь", "Россия", "Казахстан" };
            logger.LogInformation("Information: Index");
            return View();
        }

        [Route("Home/One")]
        [Route("One")]
        [Route("1")]
        public IActionResult One(int id)
        {
            logger.LogInformation("Information: One = " + id.ToString());
            return View();
        }

        [Route("Home/Two")]
        [Route("Two")]
        [Route("2")]
        public IActionResult Two()
        {
            logger.LogInformation("Information: Two");
            return View();
        }

        [Route("square/{k:int}")]
        public IActionResult Square(int k)
        {
            ViewBag.Result = k * k;
            return View();
        }

        [Route("yearsold/{n:minlength(1):maxlength(10)}/{y:int:min(1):max(150)}")]
        public IActionResult YearsOld(string n, int y)
        {
            return Content($"Your name is {n}, you're {y} years old");
        }
    }
}

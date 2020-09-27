using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core_30.Models;

namespace Core_30.Controllers
{
    public class HomeController : Controller
    {
        public class A
        {
            public string s;
            public int x, y = 0;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Partial()
        {
            return PartialView("Partial_1", new A { s = "Partial", x = 30, y = 50 });
        }

        public IActionResult List()
        {
            List<string> City = new List<string>() { "Минск", "Гомель", "Брест", "Могилев", "Гродно", "Витебск" };
            ViewBag.City = City;
            return View();
        }
    }
}

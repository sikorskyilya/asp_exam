using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core_27.Models;
using Microsoft.AspNetCore.Mvc.Razor;

namespace Core_27.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Functions()
        {
            return View();
        }

        public IActionResult Using()
        {
            return View();
        }

        public abstract class VDemo<TM> : RazorPage<TM>
        {
            public string desription { get; set; } = "Description";
            public DateTime date { get; set; } = DateTime.Now;
        }

        public IActionResult InhString()
        {
            return View("InhString", "Строка");
        }

        public IActionResult InhDate()
        {
            return View("InhDate", DateTime.Now);
        }
    }
}

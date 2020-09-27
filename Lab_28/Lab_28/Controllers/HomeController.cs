using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab_28.Models;
using System.ComponentModel.DataAnnotations;

namespace Lab_28.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Person(int age, string name)
        {
            return Content($"Age: {age}, name: {name}");
        }

        public class CA01
        {
            [Display(Name = "Параметр x")]
            public int x { get; set; }
            [Display(Name = "Параметр y")]
            public int y { get; set; }
        }

        public IActionResult A01(int x, int y)
        {
            if (ModelState.IsValid) ViewBag.XError = "Нет ошибок в данных";
            else ViewBag.XError = "Есть ошибки в данных";
            return View("Index");
        }
    }
}

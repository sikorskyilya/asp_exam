using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core_26.Models;

namespace Core_26.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() // 1
        {
            return View();
        }

        public IActionResult Global()
        {
            return View("~/Global.cshtml");
        }

        public IActionResult Folder()
        {
            return View("~/Folder/Folder.cshtml");
        }

        public IActionResult Shared() // 2
        {
            return View("Shared");
        }

        //View() : представление по имени совпадает с вызывающим методом (1)
        //View(string viewName) : задается имя представления (2)
        //View(object model) : представление по имени совпадает с вызывающим методом и принимает данные в виде объекта model (3)
        //View(string viewName, jobject model) : задается имя представления, представление принимает данные в виде объекта model (4)

        public class A
        {
            public int x = 0;
            public int y = 0;
            public int sum()
            {
                return x + y;
            }
        }

        public IActionResult Sum() // 3
        {
            return View(new A { x = 3, y = 2 });
        }

        public IActionResult Calc() // 4
        {
            return View("Sum", new A { x = 5, y = 4 });
        }

        public class B
        {
            public string s;
            public int x, y = 0;
        }

        public IActionResult Data()
        {
            ViewBag.Title = "Передача данных в представление";
            ViewBag.Data = "ViewData";
            ViewBag.Temp = "ViewDTemp";
            List<string> City = new List<string>() { "Минск", "Гомель", "Брест", "Могилев", "Гродно", "Витебск" };
            B b = new B { s = "строка", x = 3, y = 2 };
            ViewData.Add("City", City);
            ViewData.Add("B", b);
            TempData["s"] = "строчка";
            TempData["z"] = 666;
            return View();
        }
    }
}

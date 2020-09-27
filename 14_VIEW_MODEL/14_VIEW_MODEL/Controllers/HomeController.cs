using A14_VIEW_MODEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A14_VIEW_MODEL.Controllers
{
    public class HomeController : Controller
    {

        List<Phone> phones = new List<Phone>
            {
                new Phone { Id=1, Manufacturer= "apple", Name="iPhone X", Price=56000 },
                new Phone { Id=2, Manufacturer= "apple", Name="iPhone XZ", Price=41000 },
                new Phone { Id=3, Manufacturer= "microsoft", Name="Galaxy 9", Price=9000 },
                new Phone { Id=4, Manufacturer= "microsoft", Name="Galaxy 10", Price=40000 },
                new Phone { Id=5, Manufacturer= "google", Name="Pixel 2", Price=30000 },
                new Phone { Id=6, Manufacturer= "google", Name="Pixel XL", Price=50000 }
            };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Phone()
        {
            IndexViewModel ivm = new IndexViewModel { Phones = phones };
            return View(ivm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
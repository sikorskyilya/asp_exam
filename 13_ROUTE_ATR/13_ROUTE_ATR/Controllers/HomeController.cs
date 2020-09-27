using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace _13_ROUTE_ATR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        [Route("test/{id:length(5, 7)}")] // возможны различные ограничения на route
        public void Route(int id)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"число:{id}");
            Response.Write(result.ToString());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core_24.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Core_24.Controllers
{
    public class HomeController : Controller
    {
        private string txt = "";

        public IActionResult Index()
        {
            return View();
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            this.txt += " - OnActionExecuting \n";
            Console.WriteLine(txt);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            this.txt += " - OnActionExecuted \n";
            Console.WriteLine(txt);
        }

        public IActionResult A1()
        {
            this.txt += " - Action: A1 \n";
            return Content(txt);
        }

        public IActionResult A2()
        {
            this.txt += " - Action: A2 \n";
            return Content(txt);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Content("Get");
        }

        [HttpPost]
        public IActionResult Post(string str, string num)
        {
            return Content("Post: str=" + str + "&num=" + num);
        }

        [AcceptVerbs("get", "post")]
        public IActionResult AcceptVerb()
        {
            return Content($"{HttpContext.Request.Method}");
        }
    }
}

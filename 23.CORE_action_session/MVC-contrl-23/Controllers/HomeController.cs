using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCcontrl23.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCcontrl23.Controllers
{
    public class HomeController : Controller
    {
        
        
        
        public IActionResult Index()
        {
            
            return Content("Path: "+ ControllerContext.HttpContext.Request.Path + "\nMethod: " + ControllerContext.HttpContext.Request.Method);
        }

        public IActionResult Util()
        {
            return new HtmlResult("<h1>Action Result</h1>");
        }

    }
}

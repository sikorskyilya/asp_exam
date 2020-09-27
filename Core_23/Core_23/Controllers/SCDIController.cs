using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Core_23.Controllers
{
    public class SCDIController : Controller
    {
        private SCDI scdi;
        public SCDIController(SCDI scdi)
        {
            this.scdi = scdi;
        }
        public IActionResult Index()
        {
            return Content("Index: " + scdi.Get());
        }
        public IActionResult Get()
        {
            return Content("Get: " + scdi.Get());
        }
        public IActionResult Set(string s)
        {
            return Content("Set: " + scdi.Set(s));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Core_23.Controllers
{
    public class CDIController : Controller
    {
        private CDI cdi;
        public CDIController(CDI cdi)
        {
            this.cdi = cdi;
        }
        public IActionResult Index()
        {
            return Content("Index: " + cdi.Get());
        }
        public IActionResult Get()
        {
            return Content("Get: " + cdi.Get());
        }
        public IActionResult Set(string s)
        {
            return Content("Set: " + cdi.Set(s));
        }
    }
}
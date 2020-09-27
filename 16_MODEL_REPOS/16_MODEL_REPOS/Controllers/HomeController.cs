using _16_MODEL_REPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_MODEL_REPOS.Controllers
{
    public class HomeController : Controller
    {
        PhoneRepository phoneRepository = new PhoneRepository();


        public ActionResult Index()
        {
            
            return View();
        }
        [Route("all")]
        public ActionResult GetAll()
        {

            ViewBag.GetAll = phoneRepository.GetPhone();
            return View();
        }
        [Route("{one}/{id:int}")]
        public ActionResult GetOne(int id)
        {
            ViewBag.GetOne = phoneRepository.GetPhoneByID(id);
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
    }
}
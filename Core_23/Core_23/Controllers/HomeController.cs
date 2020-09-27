using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core_23.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Core_23.Controllers
{
    public class HomeController : Controller
    {
        private readonly string txt;

        public HomeController()
        {
            this.txt = "Constructor";
            ModelStateDictionary mst = this.ControllerContext.ModelState; // валидация данных
        }

        [ActionContext] // внедрение контекста
        public ActionContext actx { get; set; }

        public HttpContext httpContext => actx.HttpContext;

        public IActionResult Index()
        {
            // контекст контроллера
            //ControllerActionDescriptor cad = this.ControllerContext.ActionDescriptor; // вызываемое действие контроллера
            //RouteData rdt = this.ControllerContext.RouteData; // данные маршрута

            //HttpContext hcx = this.ControllerContext.HttpContext; // контекст запроса
            //HttpRequest req = hcx.Request; // запрос
            //HttpResponse res = hcx.Response; // ответ
            //ISession ses = hcx.Session; // сессия
            //ClaimsPrincipal clm = hcx.User; // информация о пользователе

            HttpRequest req = httpContext.Request;
            HttpResponse res = httpContext.Response; 

            return Content($"Content: {txt}");
        }

        public IActionResult KYAAction()
        {
            return new KYAResult("KYAParam");
        }
    }
}

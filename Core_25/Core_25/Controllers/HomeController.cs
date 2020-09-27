using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core_25.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace Core_25.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [AuthorizationFilter]
        public IActionResult Authorization()
        {
            Console.WriteLine("AuthorizationFilter");
            return Content("AuthorizationFilter");
        }

        [ResourceFilter]
        public IActionResult Resource()
        {
            Console.WriteLine("ResourceFilter");
            return Content("ResourceFilter");
        }

        [ActionFilter]
        public IActionResult Action()
        {
            Console.WriteLine("ActionFilter");
            return Content("ActionFilter");
        }

        [ExceptionFilter]
        public IActionResult Exception()
        {
            throw new Exception("Exception");
            Console.WriteLine("ExceptionFilter");
            return Content("ExceptionFilter");
        }

        [ResultFilter]
        public IActionResult Result()
        {
            Console.WriteLine("ResultFilter");
            return Content("ResultFilter");
        }

        [AuthorizationFilter] [ResourceFilter] [ActionFilter] [ExceptionFilter] [ResultFilter]
        public IActionResult All()
        {
            Console.WriteLine("AllFilter");
            return Content("AllFilter");
        }

        [CustomerFilter]
        public IActionResult Customer(int id)
        {
            return Content($"id = {id}");
        }

        public class AuthorizationFilter : Attribute, IAuthorizationFilter
        {
            public void OnAuthorization(AuthorizationFilterContext filterContext)
            {
                Console.WriteLine("AuthorizationFilter: OnAuthorization");
            }
        }

        public class ResourceFilter : Attribute, IResourceFilter
        {
            public void OnResourceExecuted(ResourceExecutedContext filterContext)
            {
                Console.WriteLine("ResourceFilter: OnResourceExecuted");
            }

            public void OnResourceExecuting(ResourceExecutingContext filterContext)
            {
                Console.WriteLine("ResourceFilter: OnResourceExecuting");
            }
        }

        public class ActionFilter : Attribute, IActionFilter
        {
            public void OnActionExecuted(ActionExecutedContext filterContext)
            {
                Console.WriteLine("ActionFilter: OnActionExecuted");
            }

            public void OnActionExecuting(ActionExecutingContext filterContext)
            {
                Console.WriteLine("ActionFilter: OnActionExecuting");
            }
        }

        public class ExceptionFilter : Attribute, IExceptionFilter
        {
            public void OnException(ExceptionContext filterContext)
            {
                //Console.WriteLine("ExceptionFilter: OnException");
                string actionName = filterContext.ActionDescriptor.DisplayName;
                string exceptionStack = filterContext.Exception.StackTrace;
                string exceptionMessage = filterContext.Exception.Message;
                filterContext.Result = new ContentResult
                {
                    Content = $"В методе {actionName} возникло исключение: \n {exceptionMessage} \n {exceptionStack}"
                };
                filterContext.ExceptionHandled = true;
            }
        }

        public class ResultFilter : Attribute, IResultFilter
        {
            public void OnResultExecuted(ResultExecutedContext filterContext)
            {
                Console.WriteLine("ResultFilter: OnResultExecuted");
            }

            public void OnResultExecuting(ResultExecutingContext filterContext)
            {
                Console.WriteLine("ResultFilter: OnResultExecuting");
            }
        }

        public class CustomerFilter : Attribute, IAsyncActionFilter
        {
            public async Task OnActionExecutionAsync(ActionExecutingContext context,
                                                            ActionExecutionDelegate next)
            {
                if (context.ModelState.IsValid == true)
                    context.ActionArguments["id"] = 34;
                await next();
            }
        }
    }
}

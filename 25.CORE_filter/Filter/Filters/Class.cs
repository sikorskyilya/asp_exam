using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Filter.Filters
{
    public class IEFilterAttribute : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {

        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            // получаем информацию о браузере пользователя
            string userAgent = context.HttpContext.Request.Headers["User-Agent"].ToString();
            Console.WriteLine(userAgent);
            

        }
    }
}

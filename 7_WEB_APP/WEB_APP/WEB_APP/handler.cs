using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_APP
{
    public class handler : IHttpHandler
    {
        public bool IsReusable { get { return false; } } //указывает на переиспользование объекта false- для каждого свой true - для одного

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("Hello World!");
        }
    }
}
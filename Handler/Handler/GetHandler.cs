using System;
using System.Web;

namespace Handler
{
    public class GetHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse res = context.Response;
            res.Write("Get Handler");
        }
    }
}

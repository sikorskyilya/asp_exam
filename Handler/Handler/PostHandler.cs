using System;
using System.Web;

namespace Handler
{
    public class PostHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse res = context.Response;
            res.Write("Post Handler");
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_23
{
    public class KYAResult: IActionResult
    {
        string html = "<DOCTYPE html>\n"
            + "<html>\n"
            + "<head>\n"
            + "<title>KYAResult</title>\n"
            + "<meta charset=utf-8 />\n"
            + "</head>\n"
            + "</body>\n"
            + "<h1>{0}</h1>\n"
            + "</body>\n"
            + "</html>\n";
        string txt;

        public KYAResult(string txt)
        {
            this.txt = txt;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            await context.HttpContext.Response.WriteAsync(string.Format(html, txt));
        }
    }
}

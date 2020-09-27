using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_31
{
    public static class Helper
    {
        public static IHtmlContent Customer(this IHtmlHelper html, string parm)
        {
            TagBuilder form = new TagBuilder("form");
            form.MergeAttribute("method", "post");
            form.MergeAttribute("action", "Home/Post");

            TagBuilder div = new TagBuilder("div");
            form.InnerHtml.AppendHtml(div);

            TagBuilder input = new TagBuilder("input");
            input.MergeAttribute("type", "text");
            input.MergeAttribute("id", "surname");
            input.MergeAttribute("name", "surname");
            form.InnerHtml.AppendHtml(input);

            input = new TagBuilder("input");
            input.MergeAttribute("type", "submit");
            form.InnerHtml.AppendHtml(input);

            return form;
        }
    }
}

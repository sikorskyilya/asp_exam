﻿using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

//ASP.NET CORE: MVC-представление, вспомогательные 
//методы представления(хелперы). Пример.
namespace WebApplication1.Helpers
{
    public static class ListHelper
    {
        public static HtmlString CreateList(this IHtmlHelper html, string[] items)
        {
            TagBuilder ul = new TagBuilder("ul");
            foreach (string item in items)
            {
                TagBuilder li = new TagBuilder("li");
                // добавляем текст в li
                li.InnerHtml.Append(item);
                // добавляем li в ul
                ul.InnerHtml.AppendHtml(li);
            }
            ul.Attributes.Add("class", "itemsList");
            var writer = new System.IO.StringWriter();
            ul.WriteTo(writer, HtmlEncoder.Default);
            return new HtmlString(writer.ToString());
        }
    }
}

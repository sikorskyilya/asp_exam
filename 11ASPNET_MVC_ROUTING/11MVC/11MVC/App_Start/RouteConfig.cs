using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _11MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}"); //отключает обработку запросов для некоторых файлов, в данном случае .axd

            routes.MapRoute(
                name: "Default", //имя маршрута
                url: "{controller}/{action}/{id}", //шаблон строки запроса 
                defaults: new { controller = "Home", action = "Ekz", id = UrlParameter.Optional } //значения по умолчанию для маршрута
            );
        }
    }
}

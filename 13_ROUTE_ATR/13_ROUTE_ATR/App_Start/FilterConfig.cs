﻿using System.Web;
using System.Web.Mvc;

namespace _13_ROUTE_ATR
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

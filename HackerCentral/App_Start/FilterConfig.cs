﻿using HackerCentral.Filters;
using System.Web;
using System.Web.Mvc;

namespace HackerCentral
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
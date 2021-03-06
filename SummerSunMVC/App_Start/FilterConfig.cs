﻿using SummerSunMVC.Filter;
using System.Web;
using System.Web.Mvc;

namespace SummerSunMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new TrackTimeFilter());
        }
    }
}

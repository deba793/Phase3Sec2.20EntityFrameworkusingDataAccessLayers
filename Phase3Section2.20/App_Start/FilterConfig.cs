﻿using System.Web;
using System.Web.Mvc;

namespace Phase3Section2._20
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

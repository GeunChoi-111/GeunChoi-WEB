﻿using FM.RND.Filters;
using System.Web;
using System.Web.Mvc;

namespace FM.RND
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new GlobalHandleErrorAttribute());
        }
    }
}

﻿using System.Web;
using System.Web.Mvc;

namespace LISTCRUD18032021
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

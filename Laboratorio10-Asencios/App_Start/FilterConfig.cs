﻿using System.Web;
using System.Web.Mvc;

namespace Laboratorio10_Asencios
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

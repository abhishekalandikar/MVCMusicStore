﻿using System.Web.Mvc;

namespace MVCMusicStore
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            // Add other global filters if necessary
        }
    }
}

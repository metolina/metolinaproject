﻿using System.Web;
using System.Web.Mvc;

namespace WebUI.Metolina
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}

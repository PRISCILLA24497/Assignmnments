﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceptionhandlingMVC.Controllers
{
    public class HomeController : Controller
    {
        [HandleError]
        public ActionResult Index()
        {
			throw new Exception("This is an Exception");
			
				//return RedirectToAction("Index", "Error");
			
        }

		public ActionResult About()
		{

			throw new Exception("This is a exception");

		}
	}
}
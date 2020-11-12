using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HeplersViews_Bag_tempView_Data.Controllers
{
    public class HomeController : Controller
    {
		// GET: Home
		//viewdata
		public ActionResult Index()
		{
			ViewData["name"] = "Priscilla";
			ViewData["check"] = 1;
			ViewData["As"] = 970122;
			ViewData["lastname"] = "lastname enter";
			return View();
		}
		//viewbag

		public ActionResult About()
		{
			ViewBag["name"] = "Priscilla";
			ViewBag["check"] = 1;
			ViewBag["As"] = 970122;
			ViewBag["lastname"] = "lastname enter";
			return View();
		}

		//temp data
		public ActionResult Index1()//Action
		{
			ViewData["name"] = "Priscilla";

			return RedirectToAction("code");
		}
		public ActionResult code()
		{

			ViewBag.data = TempData["name"].ToString();
			return View();


		}
	}
}
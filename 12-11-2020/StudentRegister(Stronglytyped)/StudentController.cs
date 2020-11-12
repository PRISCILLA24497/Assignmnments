using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Student_Register.Models;


namespace Student_Register.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
		[HttpPost]
		public ActionResult Index(Student s)
		{
			return View();
		}
	}
}  
    
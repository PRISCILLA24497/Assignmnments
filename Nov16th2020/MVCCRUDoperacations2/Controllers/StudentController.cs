using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCRUDoperations.Context;
using System.Data.Entity;


namespace MVCCRUDoperations.Controllers
{
    public class StudentController : Controller
    {
		// GET: Student


		priscilla1Entities1 dbobj = new priscilla1Entities1();

		public ActionResult Student(student obj)
        {
			if (obj != null)
				return View(obj);
			else
				return View();
        }
		[HttpPost]
		 public ActionResult AddStudent(student model)
		{
			if (ModelState.IsValid)
			{
				student obj = new student();

				obj.sname = model.sname;
				obj.age = model.age;
				obj.course = model.course;
				obj.city = model.city;
				obj.cid = model.cid;
				obj.sid = model.sid;

				dbobj.students.Add(obj);
				dbobj.SaveChanges();
			}
			ModelState.Clear();
			return View("Student");
		}

		public ActionResult StudentList()
		{
			var res = dbobj.students.ToList();

			return View(res);
		}

		public ActionResult Delete(int id)
		{
			var res = dbobj.students.Where(x => x.sid == id).First();
			dbobj.students.Remove(res);
			dbobj.SaveChanges();

			var list = dbobj.students.ToList();


			return View("StudentList",list);
		}

	}

}
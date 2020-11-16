using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp.Models;
using MVCappdbcl.Dboperations;



namespace MVCappdb.Controllers
{
    public class EmployeeController : Controller
    {
		EmployeesReposistory reposistory = null;

		public EmployeeController()
		{
			reposistory = new EmployeesReposistory();
		}
       
        public ActionResult Create()
        {
            return View();
        }
		[HttpPost]
		public ActionResult Create(Employeemodel model)

		{
			if(ModelState.IsValid)
			{
				int id = reposistory.AddEmployee(model);
				if(id>0)
				{
					ModelState.Clear();
					ViewBag.Issuccess = "Data Added";
				}
			}
			return View();
		}
		public ActionResult GetAllRecords()
		{
			var result = reposistory.GetAllEmployees();

			return View(result);
		}
		public ActionResult Details(int id)
		{
			var employee = reposistory.GetEmployee(id);
			return View(employee);
		}
		public ActionResult Edit(int id)
		{
			var employee = reposistory.GetEmployee(id);
			return View(employee);
		}
		[HttpPost]
		public ActionResult Edit(Employeemodel model)
		{
	                 if(ModelState.IsValid)
			{
				reposistory.UpdateEmployee(model.Id, model);
				return RedirectToAction("GetAllRecords");
			}
			return View();
		}
		
		public ActionResult Delete(int id)
		{
			reposistory.DeleteEmployee(id);
			return RedirectToAction("GetAllRecords");
		}
	}
}
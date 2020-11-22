using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using WebApimvc.Models;

namespace WebApimvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable<MvcEmployeeModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Employees").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<MvcEmployeeModel>>().Result;
            return View(empList);
        }
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)

                return View(new MvcEmployeeModel());

            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Employees/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<MvcEmployeeModel>().Result);
             
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(MvcEmployeeModel emp)
        {
            if (emp.EID==0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Employees", emp).Result;

                TempData["Success Message"] = "Saved Successfully";
            }
            else {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Employees/" + emp.EID, emp).Result;


                TempData["Success Message"] = "Updated Successfully";
            }
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Employees/" + id.ToString()).Result;//this web api cal will insert new record into employee table and store the call result intoo "response" object
            TempData["SuccessMessage"] = "Deleted Sucessfully";
            return RedirectToAction("Index");

        }
    }
}

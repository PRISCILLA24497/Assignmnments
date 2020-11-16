using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Models;


namespace MVCappdbcl.Dboperations
{
	public class EmployeesReposistory
	{
		public int AddEmployee(Employeemodel model)
		{
			using (var context = new EmployeedbEntities())
			{
				Employee emp = new Employee()
				{
					FirstName = model.FirstName,
					LastName = model.LastName,
					Email = model.Email,
					Code = model.Code
				};
				context.Employee.Add(emp);
				context.SaveChanges();

				return emp.Id;

			}
		}
		public List<Employeemodel> GetAllEmployees()
		{
			using (var context = new EmployeedbEntities())
			{
				var result = context.Employee
					.Select(x => new Employeemodel()
					{
						Id = x.Id,
						Addressid = x.Addressid,
						Code = x.Code,
						Email = x.Email,
						FirstName = x.FirstName,
						LastName = x.LastName,
						Address = new AddressModel()
						{
							Id = x.Address.Id,
							Details = x.Address.Details,
							Country = x.Address.Country,
							State = x.Address.State
						}
					}).ToList();
				return result;
			}

		}
		public Employeemodel GetEmployee(int id)
		{
			using (var context = new EmployeedbEntities())
			{
				var result = context.Employee
					.Where(x => x.Id == id)
					.Select(x => new Employeemodel()
					{
						Id = x.Id,
						Addressid = x.Addressid,
						Code = x.Code,
						Email = x.Email,
						FirstName = x.FirstName,
						LastName = x.LastName,
						Address = new AddressModel()
						{
							Id = x.Address.Id,
							Details = x.Address.Details,
							Country = x.Address.Country,
							State = x.Address.State
						}
					}).FirstOrDefault();
				return result;
			}

		}
		public bool UpdateEmployee(int id, Employeemodel model)
		{
			using (var context = new EmployeedbEntities())
			{
				//var employee = context.Employee.FirstOrDefault(x => x.Id == id);
				var employee = new Employee();


				if (employee != null)
				{
					employee.Id = model.Id;
					employee.FirstName = model.FirstName;
					employee.LastName = model.LastName;
					employee.Email = model.Email;
					employee.Code = model.Code;
					employee.Addressid = model.Addressid;
				}
				context.Entry(employee).State = System.Data.Entity.EntityState.Modified;
				context.SaveChanges();
				return true;
			}
		}

		//		public bool DeleteEmployee(int id)
		//		{
		//			using (var context = new EmployeedbEntities())
		//			{
		//				var employee = context.Employee.FirstOrDefault(x => x.Id == id);
		//				if (employee != null)
		//				{
		//					context.Employee.Remove(employee);
		//					context.SaveChanges();
		//					return true;

		//				}
		//				return false;
		//			}
		//		}

		//	}
		//}

		public bool DeleteEmployee(int id)
		{
			using (var context = new EmployeedbEntities())
			{
				var emp = new Employee()
				{
					Id = id
				};

				context.Entry(emp).State = System.Data.Entity.EntityState.Deleted;


				context.SaveChanges();
				return false;
			}
		}
	}
}
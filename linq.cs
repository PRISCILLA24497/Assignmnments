using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqsample
{

    //Implement the LINQ on collections -LIST example
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public string Designation { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> elist = new List<Employee>()
            {


               new Employee() { EmpId = 1, EmpName = "Priscilla", Salary = 27000, Designation = "Developer" },
            new Employee() { EmpId = 2, EmpName = "Vatsala", Salary = 23000, Designation = "DBAdminisator" },
            new Employee() { EmpId = 3, EmpName = "Blessy", Salary = 22000, Designation = "Developer" },
            new Employee() { EmpId = 4, EmpName = "Soumya", Salary = 21000, Designation = "Manager" },
            new Employee() { EmpId = 5, EmpName = "Aneesha", Salary = 20000, Designation = "TeamLeader" },
        };
            var ename = elist.Where(e => e.Salary > 20000).Select(e => e).Where(e => e.EmpId > 1).Select(e => e.EmpName);

            var ename1 = elist.Where(e => e.Designation == "Developer").Select(e => e).Where(e => e.EmpId > 0).Select(e => e.EmpId);

            var ename2 = from e in elist
                        where e.EmpId > 1 && e.EmpId < 4
                        select new { e.EmpName };

            //Sorting names using GroupBy clause
            var groupcl = from e in elist
                        group e by e.EmpName into em
                        orderby em.Key
                        select new { em.Key, em };




            foreach (var x in ename)
            {
                Console.WriteLine(x);//swathi,uha,krupa
            }
            foreach (var y in ename1)
            {
                Console.WriteLine(y);//1,2
            }
            foreach (var z in ename2)
            {
                Console.WriteLine(z);//swathi,usha
            }
            foreach (var a in groupcl)
            {
                Console.WriteLine("EmpName{0}", a.Key);
            }
            Console.ReadKey();
        }
    }
}
   
     
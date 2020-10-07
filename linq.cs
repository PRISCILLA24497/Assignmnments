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
    public class Employee1
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public string Designation { get; set; }

    }
    class linq
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

            List<Employee1> elist1 = new List<Employee1>()
            {
                 new Employee1() { EmpId = 1, Designation="Associate"},
                 new Employee1() { EmpId = 2, Designation="DBAdmin"},
                 new Employee1() { EmpId = 3, Designation="TechLead"},
                 new Employee1() { EmpId = 4, Designation="Manager"},


            };
            var ename = elist.Where(e => e.Salary > 20000).Select(e => e).Where(e => e.EmpId > 1).Select(e => e.EmpName);

            var ename1 = elist.Where(e => e.Designation == "Developer").Select(e => e).Where(e => e.EmpId > 0).Select(e => e.EmpId);

            var ename2 = from e in elist
                         where e.EmpId > 1 && e.EmpId < 4
                         select new { e.EmpName };

            //Sorting names using GroupBy clause
            var groupl = from e in elist
                         group e by e.EmpName into em
                         orderby em.Key
                         select new { em.Key, em };
          //  working with joins using linq
           var join = from e1 in elist
                        join e2 in elist1
                        on e1.EmpId equals e2.EmpId
                        select new
                        {
                            Name = e1.EmpName,
                            Des = e2.Designation
                        };
            foreach (var x in join)
            {
                Console.WriteLine("EmpName:" +x.Name+ " " + "Designation:"+ x.Des);
            }
            Console.ReadKey();



            foreach (var n in ename)
            {
                Console.WriteLine(n);//
            }
            foreach (var m in ename1)
            {
                Console.WriteLine(m);//
            }
            foreach (var l in ename2)
            {
                Console.WriteLine(l);//
            }
            foreach (var x in groupl)
            {
                Console.WriteLine("EmpName{0}", x.Key);
            }
            Console.ReadKey();
        }
    }
}
   
     
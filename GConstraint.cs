using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConstraint
{
    class GConstraint
    {
        
    // default parameter-less constructor
        class MyClass<T> where T : new()       // Generic parameter-less constructor constraint
        {
            public void Test()
            {
                Console.WriteLine("This is My DotNet Class");
                Console.ReadLine();
            }
        }
       class Generic<T> where T : IEmployee
        {
            public void Test1()
            {
                Console.WriteLine("This Clas implements IEmployee Interface ");
                Console.ReadLine();
            }
        }

        public interface IEmployee
        {
        }

        public class Employee : IEmployee
        {
            

        }

            public class Customer
            {
            }

        
       
        static void Main(string[] args)
        {
            MyClass<GConstraint> my = new MyClass<GConstraint>();
            my.Test();
            Generic<Employee> employee = new Generic<Employee>(); //No Error, as Emplyoee implements the IEmployee interface

            // Generic<Customer> customer = new Generic<Customer>(); //Error, as Customer does not implements the IEmployee interface
            employee.Test1();

        }
    }
}
        
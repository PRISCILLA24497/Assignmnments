using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflectionex
{
    class Employee
    {

        // Properties definition 
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        // No Argument Constructor 
        public Employee()
        {
            EmpId = 0;
            EmpName = string.Empty;
        }

        // Parameterised Constructor 
        public Employee(int eno, string ename)
        {
            EmpId = eno;
            EmpName = ename;
        }

        // Method to Display Student Data 
        public void displayData()
        {
            Console.WriteLine("Employee ID : {0}", EmpId);
            Console.WriteLine(" Employee Name : {0}", EmpName);
        }
    }

    
            
class reflex
    {
        static void Main(string[] args)
        {
                // Declare Instance of class Assembly 
                // Call the GetExecutingAssembly method 
                // to load the current assembly 
                Assembly executing = Assembly.GetExecutingAssembly();

                // Array to store types of the assembly 
                Type[] types = executing.GetTypes();
                foreach (var x in types)
                {
                    // Display each type 
                    Console.WriteLine("Class : {0}", x.Name);
                Console.ReadLine();

                    // Array to store methods 
                    MethodInfo[] methods = x.GetMethods();
                    foreach (var method in methods)
                    {
                        // Display each method 
                        Console.WriteLine("Method : {0}", method.Name);


                        // Array to store parameters 
                        ParameterInfo[] parameters = method.GetParameters();
                        foreach (var arg in parameters)
                        {
                            // Display each parameter 
                            Console.WriteLine("Parameter : {0} Type : {1}",  arg.Name, arg.ParameterType);
                        }
                    Console.ReadLine();
                    }
                }
            }
        }
    }

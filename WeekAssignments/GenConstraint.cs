using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Constraint
{

    class GenConstraint
    {
        // default parameter-less constructor
        class MyClass<T> where T : new()       // Generic parameter-less constructor constraint
    {
        public void Test()
        {
                Console.WriteLine("This is My c# programming class");
            Console.ReadLine();
        }
    }
    class Generic<T> where T : IStudent
        {
        public void Test1()
        {
            Console.WriteLine("This Class implements IStudent Interface ");
            Console.ReadLine();
        }
    }

    public interface IStudent
    {
    }

    public class Student :IStudent
    {


    }

    public class College: IStudent
        {
    }



    static void Main(string[] args)
    {
        MyClass<GenConstraint> my = new MyClass<GenConstraint>();
        my.Test();
        Generic<Student> Student = new Generic<Student>(); //No Error, as Emplyoee implements the IStudent interface

          
               Student.Test1();

    }
}
}
        
    
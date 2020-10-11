using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class sample<T>
    {
        T data;//Type parameter
        //method for class

        public sample(T check)//check assigned to type parameter
        {
            this.data = check;


        }
        public void Write()
        {
            Console.WriteLine("The  data passed initializer is:" + this.data);
            Console.ReadLine();
        }
    }





    //main method
    class Genrics
    {
        static void Main(string[] args)
        {
            //use the generic type example with an integer/string type of parameter

            sample<int> result = new sample<int>(100);
            sample<string> result1 = new sample<string>("Priscilla");

            result.Write();
            result1.Write();
        }
    }
}

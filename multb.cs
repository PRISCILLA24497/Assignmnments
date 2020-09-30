using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpfun
{
    class multb
    {
        static void Main(string[] args)
        {
            //Multiplication table
            int i, n;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
           // logic
            for (i=1; i<=20; i++)
            {
                Console.WriteLine("{0}*{1}={2}\n", n, i, n * i);

                


            }
            Console.ReadLine();
        }


        // palindrome

           
    }
}

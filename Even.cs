using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evennum
{
    class Even
    {
        static void Main(string[] args)
        {
            int i, n;

            Console.WriteLine("Enter the value of n");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Even natural numbers:\n");
            Console.ReadLine();


            for (i = 1; i <= n; i++)

            {

                if (i % 2 == 0)
                {
                    Console.WriteLine("Even natural numbers:\n");
                    Console.ReadLine();
                    Console.WriteLine(i);



                }





            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natural_numbers
{
    class Naturalnum
    {
        static void Main(string[] args)
        {
            int i, n,j,m;

            Console.WriteLine("Enter the value of n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("The  reverse order of natural numbers are");
            for (i = n; i >= 1; i--)

            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


// natural numbers in reverse oder
            Console.WriteLine("Enter the value of m");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("The  natural numbers are");
            for (j = 1; j <= m; j++)
            {


                Console.WriteLine(j);
            }

                 Console.ReadLine();

        }
            

        }
    


}



           
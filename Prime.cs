using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    class Prime
    {
        static void Main(string[] args)
        {
            int n, i, m = 0;
            Console.Write("Enter the Number to check Prime: ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i !=0)
                {
                    Console.Write("Number is  Prime");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Number is not a prime");
                    Console.ReadLine();

                }
            }
           
}
    }
}

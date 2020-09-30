using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofdigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int  sum=0, r;
            Console.WriteLine("Enter the value of n:");
           int  n =Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
            Console.WriteLine($"The sum of the digits of given number is: {sum}");
            Console.ReadLine();

        }
    }
}

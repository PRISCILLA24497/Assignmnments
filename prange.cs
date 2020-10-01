using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerange
{
    class prange
    {
        static void Main(string[] args)
        {
            int i=2, j=100, sum, num;
            //prime from 2 to 100
            Console.WriteLine("The prime numbers between 2 - 100 are");
            Console.ReadLine();
            
            for (num = i; num <= j; num++)
            {
                sum = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        sum++;
                        break;
                    }
}

                if (sum == 0 && num != 1)
                    Console.WriteLine("{0} ", num);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
        //prime in range

        //    for (num = i; num <= j; num++)
        //    {
        //        sum = 0;

        //        for (i = 2; i <= num / 2; i++)
        //        {
        //            if (num % i == 0)
        //            {
        //                sum++;
        //                break;
        //            }
        //        }

        //        if (sum == 0 && num != 1)
        //            Console.WriteLine("{0} ", num);
        //    }
        //    Console.WriteLine("\n");
        //    Console.ReadLine();
        //}
        
    }
}

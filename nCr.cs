using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCR
{
    class nCr
    {
       
            static int nCr(int n, int r)
            {
                return fact(n) / (fact(r) *
                              fact(n - r));
            }

        
            static int fact(int n)
            {
                int res = 1;
                for (int i = 2; i <= n; i++)
                    res = res * i;
                return res;
            }

        public static void Main(string[] args)
        {

            int n, r;
            Console.WriteLine("Enter the value of n");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of r");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" The value of nCr is\n" +nCr(n, r));
            Console.ReadLine();
            }
        }

    }
    
  
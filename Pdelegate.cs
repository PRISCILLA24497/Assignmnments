using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action<int, int> adddel = add;
            //adddel(1, 2);
           // Func<int, int, int> sumfunc = sum;
           Func<int> sumfunc = print;


            int s = sumfunc();
            Console.WriteLine(s);
            Console.ReadKey();
        }
        public static void add(int x,int y)
        {
            Console.WriteLine($"{(x + y)}");
        }
        public static int sum(int a,int b)
        {
            return a + b;
        }
        public static int print()
        {
            return 100;
        }

    }
    }

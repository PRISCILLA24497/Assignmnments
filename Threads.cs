using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Singlethread1
{
    class Threads
    {
        public int Thread1(int x, int y)
        {
            return x + y;

        }
        public int Thread2(int a)

        {
            Console.WriteLine("Thread is sleeping");
            Thread.Sleep(10000);

            return a * a * a;

        }


        public string Thread3(string str1, string str2)
        {

            return str1 + str2;
        }
        static void Main(string[] args)
        {
            Threads obj = new Threads();
            Console.WriteLine( "The sum is:"+ obj.Thread1(2,3));
            Console.WriteLine("cube is:"+obj.Thread2(20));
            Console.WriteLine("String is:" +obj.Thread3("Priscilla","Katherine"));
            Console.ReadKey();

        }
    }
}

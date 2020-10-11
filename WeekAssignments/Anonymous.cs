using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
    public delegate bool Delegate(int num);
    class anonymous
    {
        static void Main(string[] args)
        {
            Delegate obj = delegate (int n)
            {

                if (n % 2 == 0)
                {
                    return true;
                }
                else

                    return false;


            };
            bool val = obj.Invoke(10);
            bool val1 = obj.Invoke(21);
            Console.WriteLine(val);
            Console.WriteLine(val1);
            Console.ReadKey();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflectionsample
{
    class Program
    {
      public  static void Main(string[] args)
        {
            add(1,2,3);
            Console.WriteLine("add(1,2,3)");
            Console.ReadLine();
        }
        public static void add(params int[] num)
        {
            int sum = 0;
            foreach (var x in num)
            {
                sum = sum + x;
            }
        }
    }
}

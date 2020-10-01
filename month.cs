using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthdays
{
    class month

    {


        public static void Main(string[] args)
        {
            int y;
            string m;
            Console.WriteLine("Enter Year");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Month");
            m = Convert.ToString(Console.ReadLine());

            if (m == "jan"^m =="mar"^ m == "may" ^ m == "jul" ^ m == "aug "^ m == "oct" ^ m == "dec")
            {

                Console.WriteLine("31 days");
                Console.ReadLine();
            }
            else if (m == "apr"^m=="jun"^m=="sep"^m=="nov")
            {
                Console.WriteLine("30 days");
                Console.ReadLine();
            }
            else if (m == "feb")
                if ((y % 4) == 0 ^ (y % 100) == 0 ^ (y % 400) == 0)
                {
                    Console.WriteLine("29 days");
                }
                else
                {
                    Console.WriteLine("28 days");
                }


        

        Console.ReadLine();
        }
       
  
  }
}

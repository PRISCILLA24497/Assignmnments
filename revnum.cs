using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revnum
{
    class revnum
    {
        static void Main(string[] args)
        {
            int n, rev = 0, reminder;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                reminder = n % 10;
                rev = rev * 10 + reminder;
                n /= 10;
            }
            Console.Write("Reversed Number: " + rev);
            Console.ReadLine();
        }
        
    }   
}
   

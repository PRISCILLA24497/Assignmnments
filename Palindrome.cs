using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String ");
            string n = Console.ReadLine();
            char[] nArray = n.ToCharArray();
            Array.Reverse(nArray);
            string reverse = new string(nArray);
            if (n.Equals(reverse))

            {
                Console.WriteLine("Given String is a palindrome");
            }
            else

            {
                Console.WriteLine("Given string is not a palindrome");
            }
            Console.ReadKey();



        }
    }
}


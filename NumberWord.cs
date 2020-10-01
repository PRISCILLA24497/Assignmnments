using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numinword
{
    class NumberWord
    {
        public static void Main(String[] args)
        {


            {
                int val, next, num_digits;
                int[] a = new int[10];
                // words for every digits from 0 to 9
                string[] digits_words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };


                // number to be converted into words
                Console.WriteLine("Enter Value");
                val = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number: " + val);
                Console.Write("Number (words): ");
                next = 0;
                num_digits = 0;
                do
                {
                    next = val % 10;
                    a[num_digits] = next;
                    num_digits++;
                    val = val / 10;
                } while (val > 0);
                num_digits--;
                for (; num_digits >= 0; num_digits--)
                    Console.Write(digits_words[a[num_digits]] + " ");
                Console.ReadLine();
            }
        }
    }
}

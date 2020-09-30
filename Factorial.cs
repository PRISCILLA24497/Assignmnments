using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int i, fact = 1, n,j=0;
            Console.Write("Enter any Number: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    j++;

                }
                fact = fact * i;
            }

                Console.WriteLine("Factorial of given number is" + fact);
                Console.ReadKey();

               
            
                

            
                
            if(j==2)
            {
                Console.Write("Number is a Prime.");
               

            }

            else
            {
                Console.WriteLine("Number is not a  prime");
                
            }
            Console.ReadLine();




        }

               
                    }
                }
            

             
  
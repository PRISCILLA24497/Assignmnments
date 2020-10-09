using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThread
{

   

    class MultiThread
    {
       
            public int  Thread1(int x,int y)
            {
                return x + y;

            }
        public int Thread2(int a)

        {
            Thread.Sleep(10000);
            
            return a * a * a;
            
        }
     

        public string  Thread3(string str1,string str2)
        {
            
        return  str1 + str2;
        }
         static void Main(String[] args)
        {
            MultiThread mt = new MultiThread();
            Thread T1 = new Thread(delegate ()
            {
                Console.WriteLine("The sum of two numbers is: "  +mt.Thread1(2,3));
            });
            

            Thread T2 = new Thread(delegate ()
            {
                Console.WriteLine(" The cube of given num is: " +mt.Thread2(20));

            });
            Thread T3 = new Thread(delegate ()
            {
                Console.WriteLine("The Concatenation of strings: " +mt.Thread3("priscilla","Katherine"));
            });
            T1.Start();
            T2.Start();
            T3.Start();

            Console.ReadLine();
        }
 
        }
        }
            
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithread_Join
{
    class Join
    {

        public int Thread1(int x, int y)
        {
            lock (this)
            {
                return x + y;
            }
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
    static void Main(String[] args)
    {
            Console.WriteLine("Main Thread Started");
        Join j = new Join();
        Thread T1 = new Thread(delegate ()
        {
            Console.WriteLine("The sum of two numbers is: " + j.Thread1(2, 3));
        });


        Thread T2 = new Thread(delegate ()
        {
            Console.WriteLine(" The cube of given num is: " + j.Thread2(20));

        });
        Thread T3 = new Thread(delegate ()
        {
            Console.WriteLine("The Concatenation of strings: " + j.Thread3("priscilla", "Katherine"));
        });
        T1.Start();
        T2.Start();
        T3.Start();
            T1.Join();
            T2.Join();
            T3.Join();
            Console.WriteLine("Main Thread Exited!!");


            Console.ReadLine();
    }

}
        }
            
  
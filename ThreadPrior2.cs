using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TPriority3
{
    class ThreadPriority
    {
        static long count1, count2;
        public static void IncrementCount1()
        {


            while (true)

                count1 += 1;

        }

        public static void IncrementCount2()
        {


            while (true)

                count2 += 1;
        }
        static void Main(string[] args)
        {
            Thread T1 = new Thread(IncrementCount1);
            Thread T2 = new Thread(IncrementCount2);
            Console.WriteLine("Main thread is sleep");
            Thread.Sleep(5000);
            Console.WriteLine("Main thread woke up");
            //T1.Priority = System.Threading.ThreadPriority.AboveNormal;
            //T2.Priority = System.Threading.ThreadPriority.BelowNormal;

            T1.Priority = System.Threading.ThreadPriority.BelowNormal;
            T2.Priority = System.Threading.ThreadPriority.AboveNormal;


            T1.Start();
            T2.Start();
            T1.Abort();
            T2.Abort();
            T1.Join();
            T2.Join();
            Console.WriteLine("count1 is:" + count1);

            Console.WriteLine("count2 is:" + count2);

            Console.ReadLine();
        }
    }
}

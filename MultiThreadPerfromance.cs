using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

//*********************************************Multithread performance check***************************************************
namespace Thread_performance
{
    class Thread_Perform
    {
        public static void Thread1()
        {
            long count = 0;
            for (int i = 0; i <= 10000; i++)
            {
                count++;

            }
            Console.WriteLine("Number of counts" + count);
             Console.ReadLine();

        }

        public static void Thread2()
        {
            long count = 0;

            for (int i = 1; i <= 10000; i++)
            {

                count++;

            }
            Console.WriteLine("Number of counts" + count);

            // Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Thread_Perform obj = new Thread_Perform();
            Stopwatch s = new Stopwatch();
          
            Thread T1 = new Thread(Thread1);

            Thread T2 = new Thread(Thread2);

            T1.Start();
            T2.Start();
            T1.Join();
            T2.Join();
            s.Start();
            //obj.Thread1();
            //obj.Thread2();
            Console.WriteLine("Stopwatch is started");
             Console.ReadLine();

            s.Stop();


            Console.WriteLine(s.ElapsedMilliseconds);
            Console.WriteLine("Stopwatch stopped");
            Console.ReadKey();
        }
    }
}

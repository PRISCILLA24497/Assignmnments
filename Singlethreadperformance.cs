using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace SingleThread_Performance
{
    class Thread_Perform
    {
        public  void Thread1()
        {
            long count = 0;
            for (int i = 0; i <= 100000; i++)
            {
                count++;

            }
            Console.WriteLine("Number of counts" + count);
            Console.ReadLine();

        }

        public  void Thread2()
        {
            long count = 0;

            for (int i = 1; i<= 100000000; i++)


            {

                count++;

            }
            Console.WriteLine("Number of counts" + count);

             Console.ReadLine();
        }
        
            static void Main(string[] args)
            {
                Thread_Perform obj = new Thread_Perform();
                obj.Thread1();
                obj.Thread2();
           
                Stopwatch s = new Stopwatch();

             
                s.Start();

                Console.WriteLine("Stopwatch is started");
                Console.ReadLine();

                s.Stop();


                Console.WriteLine(s.ElapsedMilliseconds);
                Console.WriteLine("Stopwatch stopped");
            Console.ReadLine();
            }
        }
    }

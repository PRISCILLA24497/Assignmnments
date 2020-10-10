using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;


namespace priority1
{
     class ThreadPriority
        {
            static long count1, count2;
            public static void incrementcount1()
            {
                while (true)//indefinite loop

                    count1 += 1;


            }
            public static void incrementcount2()
            {
                while (true)//indefinite loop

                    count2 += 1;


            }
            static void Main(string[] args)
            {
                Thread T1 = new Thread(incrementcount1);//invoke the method increment count1
                Thread T2 = new Thread(incrementcount2);//invoke the method increment count2
                Console.WriteLine("main thread going to sleep for 5seconds");
                Thread.Sleep(5000);
                Console.WriteLine("main thread wokeup");
            //      T1.Priority = System.Threading.ThreadPriority.Lowest;//lowest - cpu utilization is  lowest,time taken is least
            //       T2.Priority = System.Threading.ThreadPriority.Highest;//highest -is time allocated to thread and method involved will be using more cpu utilization on method to perform specific task
            //

            T1.Priority = System.Threading.ThreadPriority.Highest;
            T2.Priority = System.Threading.ThreadPriority.Normal;

            T1.Start(); T2.Start();
                T1.Abort(); T2.Abort();
                T1.Join(); T2.Join();//if we have used join method main method will have highest priority compared to other methods
                Console.WriteLine("count1 is Lowest: " + count1);
                Console.WriteLine("count2 is Highest: " + count2);
                Console.ReadLine();
            }
        }
    }


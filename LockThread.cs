using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lock_Thread
{
    class LockThread
    {

        public void Thread1()
        {
      lock (this)
        {
                for (int i = 0; i <= 3; i++)
                {


                    Console.WriteLine("Thread1 started");
                    Console.WriteLine("Thread sleep");
                    Thread.Sleep(5000);

                    Console.WriteLine("Thread 2 started");
                   
          }
                Console.ReadLine();
            }
    }
   


        class Program
        {
            public static void Main(string[] args)
            {
                LockThread lt = new LockThread();
         
                    Thread t1 = new Thread(new ThreadStart(lt.Thread1));
                Thread t2 = new Thread(new ThreadStart(lt.Thread1));
                t1.Start();
                t2.Start();
            }
        }
    }
}


       
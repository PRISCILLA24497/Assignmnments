using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace MultiThread_Semaphore
{
    class Program
    {
        public static Semaphore semaphore = new Semaphore(1, 2);
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread T = new Thread(Semaphore)
                {
                    Name = "Thread " + i
                };
             T.Start(i);
            }
            Console.ReadKey();
        }
        static void Semaphore(object id)
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Wants to Enter into Critical Section for processing");
            try
            {
                //Blocks the current thread until the current WaitHandle receives a signal.   
                semaphore.WaitOne();
                Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is Doing its work");
                Thread.Sleep(5000);
                Console.WriteLine(Thread.CurrentThread.Name + "Exit.");
            }
            finally
            {
                //Release() method to release semaphore  
                semaphore.Release();
            }
        }
    }
}
        

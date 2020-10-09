using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Multithread_Mutex
{
    class Mutex
    {
        private static System.Threading.Mutex mutex = new System.Threading.Mutex();

        static void Main(string[] args)
        {
           
            //Create multiple threads to understand Mutex
            for (int i = 1; i <= 5; i++)
            {
                Thread T = new Thread(MutexExample);
                T.Name = "Thread " + i;
                T.Start();
            }
            Console.ReadKey();
        }
        //Method to implement syncronization using Mutex  
        static void MutexExample()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Wants to Enter Critical Section for processing");
            try
            {
                //Blocks the current thread until the current WaitOne method receives a signal.  
                //Wait until it is safe to enter. 
                mutex.WaitOne();
                Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is Processing now");
                Thread.Sleep(5000);
                Console.WriteLine("Exit: " + Thread.CurrentThread.Name + " is Completed its task");
            }
            finally
            {
                //Call the ReleaseMutex method to unblock so that other threads
                //that are trying to gain ownership of the mutex.  
                mutex.ReleaseMutex();
            }
        }
    }
}
      

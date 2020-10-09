using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DeadLock_ex
{
      
           class DeadLock
        {
            static readonly object firstLock = new object();
            static readonly object secondLock = new object();
            static void Thread1()
            {
                Console.WriteLine("Locking 1st resource");
                lock (firstLock)
                {
                    Console.WriteLine("Locked 1st resourcr");
                    // Wait until we're fairly sure the first thread
                    // has grabbed secondLock
                    Thread.Sleep(1000);
                    Console.WriteLine("Locking 2nd resource");
                    lock (secondLock)
                    {
                        Console.WriteLine("Locked 2nd resource");
                    }
                    Console.WriteLine("Released 2nd resource");
                }
            Console.WriteLine("Released 1st resourcce");
            }
            static void Main(string[] args)
            {
           
                new Thread(new ThreadStart(Thread1)).Start();
                // Wait until we're fairly sure the other thread
                // has grabbed firstLock
                Thread.Sleep(1000);
                Console.WriteLine("Locking 2nd resource");
                lock (secondLock)
                {
                    Console.WriteLine("Locked 2nd resource");
                    Console.WriteLine("Locking 1st resource");
                    lock (firstLock)
                    {
                        Console.WriteLine("Locked 1st resource");
                    }
                    Console.WriteLine("Released 1st resource");
                }
                Console.WriteLine("Released 2nd resource");
                Console.Read();
            }
        }
    }

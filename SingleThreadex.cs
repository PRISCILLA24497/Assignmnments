﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SingleThreadex
{
    class Threads
    {
        string Thread1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread1 at position " + i);
            }
            return ("End of The Thread1");
        }

        string Thread2()
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 4)
                {
                    Console.WriteLine("Thread is sleeping");
                    Thread.Sleep(10000);
                }
                    Console.WriteLine("Thread2 at position " + i);
                   
                
                   
                }
            return ("End of The Thread2");
        }

        string Thread3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread3 at position " + i);
            }
            return ("End of The Thread3");
        }
        static void Main(string[] args)
        {
            Threads obj = new Threads();
            Console.WriteLine(obj.Thread1());
            Console.WriteLine(obj.Thread2());
            Console.WriteLine(obj.Thread3());
            Console.ReadKey();
        }
    }
}

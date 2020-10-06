using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericclassex
{
    
            class Genericex<T>
        {
            public Genericex(T msg)
            {
                Console.WriteLine(msg);
            Console.ReadLine();
           
            }
        
        }
        class Program
        {
            static void Main(string[] args)
            {
                Genericex<string> gen = new Genericex<string>("This is generic class");
                Genericex<int> genI = new Genericex<int>(101);

            Genericex<float> getfloat = new Genericex<float>(0.2f);
            Genericex<Double> getdoubleval = new Genericex<Double>(3.333222222);

        }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listex
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var l = new List<string>();
            l.Add("Priscilla");
            l.Add("Monica");
            l.Add("Lily");
            l.Add("Daniel");
            l.Add("Betty");
            Console.WriteLine("List Created");
            Console.WriteLine("The elements in the list are:");
            foreach (var x in l)
            {


                Console.WriteLine(x);

            }
            Console.ReadLine();
            Console.WriteLine("The element to remove" + l.Remove("Betty"));

            
            Console.WriteLine("THe  INDEX OF THE LIST:" + l[0]);
            Console.WriteLine("THe  INDEX OF THE LIST:" + l[1]);
            
            Console.WriteLine("THe  INDEX OF THE LIST:" + l[2]);
            Console.WriteLine("THe  INDEX OF THE LIST:" + l[3]);
            Console.ReadLine();

            //INSERT (index,value)
            l.Insert(4, "Persis");
            l.Insert(5, "Acscah");
            Console.WriteLine("The inserted elements are:" +l[4]+" "+l[5]);
            Console.ReadLine();
            Console.WriteLine("Contains="+l.Contains("susana"));
            Console.ReadLine();
            Console.WriteLine("Contains="+l.Contains("Monica"));
            Console.ReadLine();

        }


    }

        }
    


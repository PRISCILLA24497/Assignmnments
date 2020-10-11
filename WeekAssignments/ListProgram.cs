using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listex
{
    class ListProgram
    {
        static void Main(string[] args)
        {
            
            var l = new List<string>();
            l.Add("Priscilla");
            l.Add("Aneeha");
            l.Add("Blessy");
            l.Add("Jessy");
            l.Add("Monica");
            l.Add("Katherine");
            l.Add("Sunny");
            l.Add("Amrutha");
            Console.WriteLine("List Created");
            Console.WriteLine("The elements in the list are:");
            foreach (var x in l)
            {


                Console.WriteLine(x);

            }
            Console.ReadLine();
            Console.WriteLine("The element to remove" + l.Remove("Priscilla"));

            
            Console.WriteLine("THe  INDEX OF THE LIST:" + l[0]);
            Console.WriteLine("THe  INDEX OF THE LIST:" + l[1]);
            
            Console.WriteLine("THe  INDEX OF THE LIST:" + l[2]);
            Console.WriteLine("THe  INDEX OF THE LIST:" + l[3]);
            Console.WriteLine("THe  INDEX OF THE LIST:" + l[4]);
            Console.WriteLine("THe  INDEX OF THE LIST:" + l[5]);
            Console.ReadLine();

            //INSERT (index,value)
            l.Insert(6, "Priya");
            l.Insert(7, "Satish");
            Console.WriteLine("The inserted elements are:" +l[6]+" "+l[7]);
            Console.ReadLine();
            Console.WriteLine("Contains="+l.Contains("persis"));
            Console.ReadLine();
            Console.WriteLine("Contains="+l.Contains("Satish"));
            Console.ReadLine();

        }


    }

        }
    


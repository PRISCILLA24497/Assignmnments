using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionarysample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> city = new Dictionary<string, string>();
         

            city.Add("1", "Banglore");
            city.Add("2", "Mumbai");
            city.Add("3", "Pune");
            city.Add("4", "Hyderabad");
            city.Add("5", "Chennai");
            city.Add("6", "Delhi");
            city["7"] = "Kolkatta";
            city["8"] = "Ahmedabad";
            city["9"] = "Noida";
            city["10"] = "Tiruvantpuram";
            Console.WriteLine("Elements in dictionary are:");
            

            foreach (KeyValuePair<string, string> x in city)
            {
                Console.WriteLine(x.Key+" " + x.Value);
               
            }
            Console.ReadLine();
            Console.WriteLine("The elements in the dictionary are:" + city.Count());
            Console.ReadLine();
            city.Remove("1");
            city.Remove("2");
            city.Remove("3");
            city.Remove("4");
            city.Remove("5");
            city.Remove("6");
            Console.WriteLine("After Removing 6times,The Elements in dictionary are:");


            foreach (KeyValuePair<string, string> x in city)
            {
                Console.WriteLine(x.Key+" " + x.Value);

            }
            Console.ReadLine();
            Console.WriteLine("The elements in the dictionary are:" + city.Count());


            city.Add("1", "Banglore");
            city.Add("2", "Mumbai");


            city.Remove("7");
            city.Remove("8");
            city.Remove("9");
            city.Remove("10");
            city.Remove("1");
            Console.WriteLine("After Removing 5times,The Elements in dictionary are:");


            foreach (KeyValuePair<string, string> x in city)
            {
                Console.WriteLine(x.Key+" " +x.Value);

            }
            Console.ReadLine();
            Console.WriteLine("The elements in the dictionary are:" + city.Count());
            city.Add("3", "Pune");
            city.Add("4", "Hyderabad");
            city.Add("5", "Chennai");
            city.Add("6", "Delhi");
            city.Remove("2");
            city.Remove("3");
            city.Remove("4");
            city.Remove("5");
            Console.WriteLine("After Removing 4times,The Elements in dictionary are:");


            foreach (KeyValuePair<string, string> x in city)
            {
                Console.WriteLine(x.Key + " " + x.Value);

            }
            Console.ReadLine();
            Console.WriteLine("The elements in the dictionary are:" + city.Count());
            Console.ReadKey();

            city["7"] = "Kolkatta";
            city["8"] = "Ahmedabad";
            city["9"] = "Noida";
             city["10"] = "Tiruvantpuram";
            city.Remove("7");
            city.Remove("8");
            city.Remove("9");
           

            Console.WriteLine("After Removing 3times,The Elements in dictionary are:");


            foreach (KeyValuePair<string, string> x in city)
            {
                Console.WriteLine(x.Key + " " + x.Value);

            }
            Console.ReadLine();
            Console.WriteLine("The elements in the dictionary are:" + city.Count());
            Console.ReadKey();
            city.Add("1", "Banglore");
            city.Remove("9");
            city.Remove("6");
            Console.WriteLine("After Removing 2times,The Elements in dictionary are:");


            foreach (KeyValuePair<string, string> x in city)
            {
                Console.WriteLine(x.Key + " " + x.Value);

            }
            Console.ReadLine();
            Console.WriteLine("The elements in the dictionary are:" + city.Count());
            Console.ReadKey();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(101, "windows");
            dict.Add(102, "linux");
            dict.Add(103, "DOS");
            foreach(KeyValuePair<int,string> pair in dict)
            {
                Console.WriteLine("{0} {1}", pair.Key, pair.Value);

            }
            Console.WriteLine("*********************************************");
            Console.WriteLine("\n");
            if (dict.ContainsKey(101))
            {
                string value = dict[101];
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("wrong choice");
            }
            string test;
          if(  dict.TryGetValue(104, out test));
            {
                Console.WriteLine(test);
            }
            Console.ReadLine();
        }
    }
}

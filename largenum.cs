using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largenumarray
{
    class largenum
    {
         static int[] arr = new int[] { 1, 2, 7, 5, 6 };
         
      
        static int largest()
        {
            
            int i;
  
            // Initialize maximum elemen
            int max = arr[0];

            // Traverse array elements from second and 
            // compare every element with current max  
            for (i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];

            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Largest in given " + "array is " + largest());
            Console.ReadLine();
        }
    }
}
    

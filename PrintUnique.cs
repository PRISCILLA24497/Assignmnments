using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace RemoveDuplicates
{
    class PrintUnique
    {

        public static int printUniqueElements(int[] arr, int n)
        {


            for (int i = 0; i < n; i++)
            {


                for (int j = i + 1; j < n;)
                {


                    if (arr[i] == arr[j])
                    {


                        for (int k = j; k < n - 1; k++)
                        {
                            arr[k] = arr[k + 1];
                        }

                        // Decreasing the array index by 1.
                        n--;

                    }
                    else
                    {


                        j++;
                    }
                }
            }


            return n;

        }
    }

    public class RemoveDuplicatesFromArrayTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of the array");
            int size;
            bool flag = int.TryParse(Console.ReadLine(), out size);

            if (flag == true)
            {
                if (size <= 0)
                {
                    Console.WriteLine("Array size cannot be Zero or Negative");
                }
            }
            flag = false;
            int[] arr = new int[size];



            Console.WriteLine("Enter the elements to store in an array");
            Console.ReadLine();

            for (int i = 0; i < size; i++)
            {
                flag = int.TryParse(Console.ReadLine(), out arr[i]);
                if (flag == false)
                {
                    return;
                }
                flag = false;
            }
            Console.WriteLine("Original Array: ");
            Console.ReadLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                Console.WriteLine("Print unique elements: ");
                Console.ReadLine();
            }
            int newSize = PrintUnique.printUniqueElements(arr, size);

            for (int i = 0; i < newSize; i++)
            {
                Console.WriteLine(arr[i]);
                Console.ReadLine();

            }
        }
    }
}

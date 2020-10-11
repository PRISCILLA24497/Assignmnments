using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jagged Array");
            //declare the array
            int[][] Jaggedarray = new int[5][];
            Jaggedarray[0] = new int[2] { 2, 3 };
            Jaggedarray[1] = new int[4] { 12, 31, 24, 36 };
            Jaggedarray[2] = new int[3] { 2, 3, 4 };
            Jaggedarray[3] = new int[5] { 10, 20, 30, 40, 50 };
            Jaggedarray[4] = new int[3] { 2, 3, 6 };


            for (int i = 0; i < Jaggedarray.Length; i++)

            {

                Console.WriteLine("Elements of({0}):", i);
                for (int j = 0; j < Jaggedarray[i].Length; j++)
                {
                    Console.WriteLine(Jaggedarray[i][j] + "\t");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
       

        }
   


    }








//            //making the above array into jagged

//           Jaggedarray[0] = new int[3];
//            Jaggedarray[1] = new int[5];
//            Jaggedarray[2] = new int[7];
//            Jaggedarray[3] = new int[9];
//            Jaggedarray[4] = new int[11];
//            //another way

//            Jaggedarray[0] = new int[] { 3, 5, 7, 9, 11 };

//            //shortand of Jagged array

//            int[][] JaggedArray =
//            {
//                new int[] {1,2,3,4,5},
//                new int[]{2,7,4,1,}
//            };

//        }
//    }
//}

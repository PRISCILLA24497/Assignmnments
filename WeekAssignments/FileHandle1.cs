using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace File_handle1
{
    class File
    {
        class FW
        {


            public void Myfile()
            {
                FileStream f = new FileStream("C:\\Daily Assignments c#\\Filehandle.txt", FileMode.OpenOrCreate);

                StreamWriter sw = new StreamWriter(f);
                StreamReader sr = new StreamReader(f);

                Console.WriteLine("Enter the Text:");
                Console.ReadKey();


                // To read the input from the user 
                string s = Console.ReadLine();
                string str = sr.ReadLine();
                // To write a line in buffer 
                sw.WriteLine(s);
                Console.WriteLine(str);
                Console.ReadLine();



                // To write in output stream 



                //To close the stream
                sw.Close();
                sr.Close();
                f.Close();
            }
        }

        //Main Method
        static void Main(string[] args)
        {
            FW w = new FW();

            w.Myfile();


            Console.ReadLine();
        }
    }
}

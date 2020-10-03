using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Directoryex
{
      class FW
        {


            public void Myfile()
            {
                FileStream f = new FileStream("C:\\Users\\pthota21\\Desktop\\sweety\\java.txt", FileMode.OpenOrCreate);

                StreamWriter sw = new StreamWriter(f);

                Console.WriteLine("Enter the Text:");


                // To read the input from the user 
                string s = Console.ReadLine();
                sw.WriteLine(s);
                sw.Close();
                f.Close();
            }
           


                class Program
                {


                    static void Main(string[] args)
                    {

                        //  var currentDirectory = Directory.GetCurrentDirectory();
                        //Console.WriteLine(currentDirectory);
                        //Console.ReadLine();
                        //Console.WriteLine(Directory.GetDirectoryRoot(currentDirectory));
                        //Console.ReadLine();

                        var docpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        var Dirname = $@"{docpath}\sweety";
                        DirectoryInfo dinfo = Directory.CreateDirectory(Dirname);
                        Console.WriteLine($"Complete name of the directory:{dinfo.FullName},Name:{dinfo.Name},Parent:{dinfo.Parent}");
                        Console.ReadLine();



                        FW w = new FW();

                        w.Myfile();


                        Console.ReadLine();

                    }
                }
            }
        }
  
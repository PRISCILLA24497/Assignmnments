using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class rectangle
    {

        // declaring delegate 
        public delegate void rectDelegate(double height,
                                          double width);

        // "area" method 
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
            Console.ReadLine();
        }

        // "perimeter" method 
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
            Console.ReadLine();
        }
   

        // Main Method 
        public static void Main(String[] args)
        {

            // creating object of class  
            // "rectangle", named as "rect" 
            rectangle rect = new rectangle();



            // creating delegate object, name as "rectdele" 
            // and pass the method as parameter by  
            // class object "rect" 
            rectDelegate rectdele = new rectDelegate(rect.area);

           
            // call 2nd method "perimeter" 
            // Multicasting 
            rectdele += rect.perimeter;

            // pass the values in two method  
            // by using "Invoke" method 
            rectdele.Invoke(10.3, 6.2);
            Console.WriteLine();

            // call the methods with  
            // different values 
            rectdele.Invoke(20.5, 15.3);
           
        }
    }
}
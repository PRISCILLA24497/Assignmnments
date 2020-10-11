using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queueex
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(200);
            q.Enqueue(400);
            q.Enqueue(600);
            q.Enqueue(800);
            q.Enqueue(1000);
            Console.WriteLine("The elements in the queue are:");
            foreach (int x in q)
            {
                Console.WriteLine(x);

            }
            Console.ReadLine();
          
            Console.WriteLine("Dequeue elements from queue:"+q.Dequeue());

            Console.WriteLine("Elements after deqeue are:");//ACCESS THE FIRST ELEMENT
            foreach (int x in q)
            {
                Console.WriteLine(x);

            }
         //   Console.ReadLine();
           

                Console.WriteLine("peek element of the queue:");
            Console.WriteLine(q.Peek());
            
          
                Console.WriteLine("The current elements present in the queue are:");
            Console.WriteLine(q.Count());
            Console.ReadLine();






        }
      
            
    }
}

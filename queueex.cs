using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queuesample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> qu = new Queue<int>();
            qu.Enqueue(2);
            qu.Enqueue(4);
            qu.Enqueue(6);
            qu.Enqueue(8);
            qu.Enqueue(10);
            qu.Enqueue(12);
            qu.Enqueue(14);
            qu.Enqueue(16);
            qu.Enqueue(18);
            qu.Enqueue(20);

            Console.WriteLine("The elements are in the Queue after Enqueue are:");
            foreach (int q in qu)
            {
                Console.WriteLine(q);

            }

            Console.WriteLine("Count is" + qu.Count());
            Console.WriteLine("The peek element of Queue is:" + qu.Peek());
            Console.ReadLine();
            qu.Dequeue();
            qu.Dequeue();
            qu.Dequeue();
            qu.Dequeue();
            qu.Dequeue();
            qu.Dequeue();
            //elements in the Queue after performing dequeue for 6 times
            Console.WriteLine("checking value in Queue"+qu.Contains(4));
            Console.WriteLine("Count is" + qu.Count());
            Console.WriteLine("elements of Queue after Dequeue:");
            foreach (int x in qu)
            {

                Console.WriteLine(x);
            }
            Console.WriteLine("The peek element of Queue is:" + qu.Peek());
            Console.ReadLine();
            Console.WriteLine("The left over elements in the Queue are:");
            foreach (int x in qu)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
            qu.Enqueue(22);
            qu.Enqueue(24);
            qu.Enqueue(26);
            Console.WriteLine("Count is" + qu.Count());
            //elements in the stack after performing pop for 5 times


            Console.WriteLine("The left over elements in the Queue are:");
            foreach (int x in qu)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
            qu.Dequeue();
            qu.Dequeue();
            qu.Dequeue();
            qu.Dequeue();
            qu.Dequeue();
            //elements in the Queue after performing dequeue for 5 times
            Console.WriteLine("checking value in Queue:" + qu.Contains(10));
            Console.WriteLine("The left over elements in the Queue are:");
            foreach (int s in qu)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();


            Console.WriteLine("elements of Queue after Dequeue:");
            foreach (int x in qu)
            {

                Console.WriteLine(x);
            }
            Console.WriteLine("The peek element of Queue is:" + qu.Peek());
            Console.ReadLine();
            Console.WriteLine("Count is" + qu.Count());



             Console.WriteLine("The left over elements in the Queue are:");
            foreach (int s in qu)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();

           
            Console.WriteLine("Count is" + qu.Count());
            Console.WriteLine("elements of Queue after Dequeue:");

            qu.Enqueue(28);
            qu.Enqueue(30);
            qu.Enqueue(32);
            Console.WriteLine("The left over elements in the Queue are:");
            foreach (int s in qu)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();

            //elements in the Queue after performing dequeue for 4 times
            Console.WriteLine("checking value in Queue:" + qu.Contains(32));
            Console.WriteLine("Count is" + qu.Count());
            Console.WriteLine("elements of Queue after Dequeue:");

            qu.Dequeue();
            qu.Dequeue();
            qu.Dequeue();
            qu.Dequeue();

            Console.WriteLine("The left over elements in the Queue are:");
            foreach (int x in qu)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();

            Console.WriteLine("Count is" + qu.Count());
            foreach (int x in qu)
            {

                Console.WriteLine(x);
            }
            Console.WriteLine("The peek element of Queue is:" + qu.Peek());
            Console.ReadLine();
            qu.Enqueue(34);
            qu.Enqueue(36);
            qu.Enqueue(38);
            qu.Enqueue(40);


            Console.WriteLine("The left over elements in the queue are:");
            foreach (int x in qu)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();

            Console.WriteLine("Count is" + qu.Count());
            //elements in the Queue after performing dequeue for 3 times

            qu.Dequeue();
            qu.Dequeue();
            qu.Dequeue();
            Console.WriteLine("checking value in Queue:" + qu.Contains(40));
            Console.WriteLine("The left over elements in the Queue are:");
            foreach (int x in qu)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();

            Console.WriteLine("Count is" + qu.Count());
            Console.WriteLine("elements of queue after dequeue:");

            foreach (int x in qu)
            {

                Console.WriteLine(x);
            }
            Console.WriteLine("The peek element of queue is:" + qu.Peek());
            Console.ReadLine();

            qu.Enqueue(42);
            qu.Enqueue(44);
            qu.Enqueue(46);



            Console.WriteLine("The left over elements in the Queue are:");
            foreach (int x in qu)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();

            Console.WriteLine("elements of Queue after dequeue:");
            //elements in the Queue after performing dequeue for 2 times

            qu.Dequeue();
            qu.Dequeue();
            Console.WriteLine("The left over elements in the Queue are:");

            Console.WriteLine("Count is" + qu.Count());



            foreach (int x in qu)
            {

                Console.WriteLine(x);
            }
            Console.WriteLine("checking value in Queue:" + qu.Contains(44));
            Console.WriteLine("Count is" + qu.Count());
            Console.WriteLine("The peek element of Queue is:" + qu.Peek());
            Console.ReadLine();
            Console.WriteLine("The left over elements in the Queue are:");
            foreach (int s in qu)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}






      





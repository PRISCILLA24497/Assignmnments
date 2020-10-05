using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackSample
{
    class stex
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            st.Push(2);
            st.Push(4);
            st.Push(6);
            st.Push(8);
            st.Push(10);
            st.Push(12);
            st.Push(14);
            st.Push(16);
            st.Push(18);
            st.Push(20);

            Console.WriteLine("The elements are in the stack after push are:");
            foreach (int s in st)
            {
                Console.WriteLine(s);

            }
            
              Console.WriteLine("Count is" + st.Count());
            Console.WriteLine("The peek element of stack is:" + st.Peek());
            Console.ReadLine();
            //elements in the stack after performing pop for 6 times

           
            st.Pop();
            st.Pop();
            st.Pop();
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("Count is" + st.Count());
            Console.WriteLine("elements of stack after pop:");
            foreach (int x in st)
            {

                Console.WriteLine(x);
            }
            Console.WriteLine("The peek element of stack is:" + st.Peek());
            Console.ReadLine();
            Console.WriteLine("The left over elements in the stack are:");
            foreach (int s in st)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        
        st.Push(22);
            st.Push(24);
            st.Push(26);
            Console.WriteLine("Count is" + st.Count());
            //elements in the stack after performing pop for 5 times
            Console.WriteLine("The left over elements in the stack are:");
            foreach (int s in st)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        

        st.Pop();
            st.Pop();
            st.Pop();
            st.Pop();
            st.Pop();
            Console.WriteLine("The left over elements in the stack are:");
            foreach (int s in st)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        

        Console.WriteLine("elements of stack after pop:");
            foreach (int x in st)
            {

                Console.WriteLine(x);
            }
            Console.WriteLine("The peek element of stack is:" + st.Peek());
            Console.ReadLine();
            Console.WriteLine("Count is" + st.Count());

            st.Push(28);
            st.Push(30);
            st.Push(32);
            Console.WriteLine("The left over elements in the stack are:");
            foreach (int s in st)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        
        //elements in the stack after performing pop for 4 times
        Console.WriteLine("Count is" + st.Count());
            Console.WriteLine("elements of stack after pop:");
            st.Pop();
            st.Pop();
            st.Pop();
            st.Pop();
            Console.WriteLine("The left over elements in the stack are:");
            foreach (int s in st)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        
        Console.WriteLine("Count is" + st.Count());
            foreach (int x in st)
            {

                Console.WriteLine(x);
            }
            Console.WriteLine("The peek element of stack is:" + st.Peek());
            Console.ReadLine();
            st.Push(34);
            st.Push(36);
            st.Push(38);
            st.Push(40);
            Console.WriteLine("The left over elements in the stack are:");
            foreach (int s in st)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        
        Console.WriteLine("Count is" + st.Count());
            //elements in the stack after performing pop for 3 times

           
            st.Pop();
            st.Pop();
            st.Pop();
            Console.WriteLine("The left over elements in the stack are:");
            foreach (int s in st)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        
        Console.WriteLine("Count is" + st.Count());
            Console.WriteLine("elements of stack after pop:");

            foreach (int x in st)
            {

                Console.WriteLine(x);
            }
            Console.WriteLine("The peek element of stack is:" + st.Peek());
            Console.ReadLine();
            st.Push(42);
            st.Push(44);
            st.Push(46);
            Console.WriteLine("The left over elements in the stack are:");
            foreach (int s in st)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        
        Console.WriteLine("elements of stack after pop:");
            //elements in the stack after performing pop for 2 times

           
            st.Pop();
            st.Pop();
            Console.WriteLine("The left over elements in the stack are:");
           
        Console.WriteLine("Count is"+st.Count());



            foreach (int x in st)
            {

                Console.WriteLine(x);
            }
            Console.WriteLine("Count is"+st.Count());
            Console.WriteLine("The peek element of stack is:" + st.Peek());
            Console.ReadLine();
            Console.WriteLine("The left over elements in the stack are:");
            foreach(int s in st)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
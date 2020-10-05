using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace StackEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack");
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
            Console.WriteLine("pop element of stack is:" + st.Pop());
            foreach (int s in st)
            {
                Console.WriteLine("elements of stack after pop:" + s);
            }
            Console.WriteLine("pop element of stack is:" + st.Pop());
            foreach (int s in st)
            {
                Console.WriteLine("elements of stack are:" + s);
            }
            Console.WriteLine("pop element of stack is:" + st.Pop());
            foreach (int s in st)
            {
                Console.WriteLine("elements of stack are:" + s);
            }
            Console.WriteLine("pop element of stack is:" + st.Pop());
            foreach (int s in st)
            {
                Console.WriteLine("elements of stack are:" + s);
            }
            Console.WriteLine("pop element of stack is:" + st.Pop());
            foreach (int s in st)
            {
                Console.WriteLine("elements of stack are:" + s);
            }
            Console.WriteLine("pop element of stack is:" + st.Pop());
            foreach (int s in st)
            {
                Console.WriteLine("elements of stack are:" + s);
            }
            Console.WriteLine("The peek element of stack is" + st.Peek());
            Console.WriteLine("The elements left in stack are");
            foreach (int s in st)
            {
                Console.WriteLine("elements of stack are:" + s);
            }
            Console.ReadKey();
        }
    }
}





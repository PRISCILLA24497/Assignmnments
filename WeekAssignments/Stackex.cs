using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_demo
{
    class Stackex
    {
        
            static void Main(string[] args)
            {
                Console.WriteLine("Stack");
                Stack<int> st = new Stack<int>();
                st.Push(100);
                st.Push(101);
                st.Push(102);
                st.Push(103);
                st.Push(104);
                st.Push(105);
                st.Push(106);
                st.Push(107);
                st.Push(108);
                st.Push(109);

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



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;
namespace Stack_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(2);
            s.Push(13.9);
            s.Push("Student");
            //Console.WriteLine(s.Contains(13.9)); // True
            //Console.WriteLine(s.Peek()); // Student
            //Console.WriteLine(s.Peek()); // Student

            //Console.WriteLine(s.Pop()); // Student
            //Console.WriteLine(s.Pop()); // 13.9

            PrintStack(s);

            Console.Read();
        }

        public static void PrintStack(Stack st)
        {
            if (st.Count == 0)
            {
                WriteLine("This stack is empty");
                return;
            }

            foreach(var element in st)
            {
                WriteLine(element);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Stack_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stringStack = new Stack<string>(10);
            stringStack.Push("Mohammad");
            stringStack.Push("Reza");
            stringStack.Push("Tahere");
            stringStack.Push("Tayyebe");
            stringStack.Push("Asghar");
            Console.WriteLine(stringStack.Pop());
            Console.WriteLine(stringStack.Pop());
            Console.Read();
        }
    }
    public class Stack<T>
    {
        private int top;
        private T[] elementArray;
        public Stack()
        {

        }

        public Stack(int stackSize)
        {
            if (stackSize > 0)
                elementArray = new T[stackSize];
            else
                throw new Exception("Stack size must be positive");
            top = -1;
        }

        public void Push(T element)
        {
            if (top == elementArray.Length - 1)
                throw new Exception(string.Format("Stack is full. you can not push {0}", element));
            top++;
            elementArray[top] = element;
        }
        public T Pop()
        { 
            if (top == -1)
                throw new Exception(string.Format("Stack is empty. you can not pop"));
            
            top--;
            return elementArray[top + 1];
        }
    }
 }



using System;
using FirstNamespace;

namespace FirstNamespace
{
    class FirstClass
    {
        public int f()
        {
            Console.WriteLine("first class");
            return 5;
        }
    }
}

namespace SecondNamespace
{
    class FirstClass
    {
        public int f()
        {
            Console.WriteLine("second class");
            return 6;
        }
    }
}

namespace Week3_Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstClass firstObject = new FirstClass();
            Console.WriteLine(firstObject.f());
            SecondNamespace.FirstClass secondObject = new SecondNamespace.FirstClass();
            Console.WriteLine(secondObject.f());
            Console.ReadKey();
        }
    }
}

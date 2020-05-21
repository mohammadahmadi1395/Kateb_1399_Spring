using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event
{
    public delegate int MethodPointer(int number1, int number2);
    class Program
    {
        public event MethodPointer myEvent;
        Program()
        {
            myEvent += Sum;
            myEvent += Subtract;                
        }
        public static int Sum(int num1, int num2)
        {
            int res = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, res);
            return res;
        }
        public static int Subtract(int num1, int num2)
        {
            int res = num1 - num2;
            Console.WriteLine("{0} - {1} = {2}", num1, num2, res);
            return res;
        }

        static void Main(string[] args)
        {
            Program p = new Program();            
            p.myEvent(10, 3);
            //MethodPointer myDel = new MethodPointer(Sum);
            //MethodPointer myDel = Sum;
            //myDel += Subtract;

            //myDel.Invoke(10, 3);
            //myDel(10, 3);

            Console.Read();
        }
    }
}

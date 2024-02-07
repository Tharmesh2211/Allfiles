using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Add(long num1, float num2)
        {
            Console.WriteLine("Sum of Both Values "+(num1+num2));
        }
        static void Sub(long num1, float num2)
        {
            Console.WriteLine("Sub of Both Values " + (num1 - num2));
        }
        static void Multi(long num1, float num2)
        {
            Console.WriteLine("Multiply of Both Values " + (num1 * num2));
        }
        static void Div(long num1, float num2)
        {
            Console.WriteLine("Divide of Both Values " + (num1 / num2));
        }
        static void Main(string[] args)
        {
            long num1 = Convert.ToUInt32(Console.ReadLine());
            float num2 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();
            Add(num1, num2);
            Sub(num1, num2);
            Multi(num1, num2);
            Div(num1, num2);
        }
    }
}

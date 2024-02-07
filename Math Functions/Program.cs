using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Function MAX : "+Math.Max(5, 10));
            Console.WriteLine("Function MIN : "+Math.Min(100,50));
            Console.WriteLine("Function SQRT : "+Math.Sqrt(34));
            Console.WriteLine("Function ABS : "+Math.Abs(-44+7));
            Console.WriteLine("Function ROUND : " + Math.Round(4.6));
            Console.WriteLine("Function POW : " + Math.Pow(10, 2));
            Console.WriteLine("Function CEIL : " + Math.Ceiling(2.2));
            Console.WriteLine("Function FLOOR : " + Math.Floor(5.9));
        }
    }
}

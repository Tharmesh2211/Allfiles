using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //MethodOverloading methodOverloading = new MethodOverloading();
            //Console.WriteLine("Adding Both Integer Value : " + methodOverloading.Add(5, 8));
            //Console.WriteLine("Adding Integer & Float Value : " + methodOverloading.Add(10, 56.2f));
            //Console.WriteLine("Adding Integer & String & Float Value : " + methodOverloading.Add(22, " 11 ", 2002));
            //Console.WriteLine("Adding Both Long Value : " + methodOverloading.Add(14325364576, 8675645324));

            MethodOverriding2 methodOverriding2 = new MethodOverriding2();
            methodOverriding2.Hi();

            MethodOverriding3 methodOverriding3 = new MethodOverriding3();
            methodOverriding3.Hi();
        }
    }
}

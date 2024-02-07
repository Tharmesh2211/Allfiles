using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployArray
{
     public class Program
     {
        public static void While(string[] array)
        {
            Console.WriteLine("Executing While Loop\n");

            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("SIS EMPLOYEE {0} - {1}", i + 1, array[i]);
                i++;
            }
        }

        public static void DoWhile(string[] array)
        {
            Console.WriteLine("Executing Do-While Loop\n");

            int i = 0;
            do
            {
                Console.WriteLine("SIS EMPLOYEE {0} - {1}", i + 1, array[i]);
                i++;
            }
            while (i < array.Length);
        }

        static void Main(string[] args)
        {
            string []array = {"tharmesh", "ganesh", "narmata", "allwn", "gopi", "priya", "sathish", "sairam", "sree","saravana","jenica","mani","kiran" };
            While(array);
            Console.WriteLine("--------------------------------------------");
            //DoWhile(array);
            Console.ReadKey();
        }
    }
}

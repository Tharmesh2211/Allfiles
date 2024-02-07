using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employ
{
    internal class Program
    {
        static void assing(int ID, int age, string address, string DOB)
        {
            Console.WriteLine("Employ ID      = "+ID);
            Console.WriteLine("Employ Age     = "+age);
            Console.WriteLine("Employ Address = "+address);
            Console.WriteLine("Employ DOB     = "+DOB);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Employ ID   : ");
            int ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employ Age  : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Address     : ");
            string address = Console.ReadLine();
            Console.Write("Enter DOB         : ");
            string DOB = Console.ReadLine();
            Console.Clear();
            assing(ID, age, address, DOB);
        }
    }
}

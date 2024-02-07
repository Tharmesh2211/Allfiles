using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Vechile
{
    internal class Bike
    {
        string name = Console.ReadLine();
        string wheels = Console.ReadLine();
        string brand = Console.ReadLine();

        static void move()
        {
            Console.WriteLine("Your Bike is Moving");
        }
        static void accelarate()
        {
            Console.WriteLine("You accelarating the Bike");
        }
        static void breakk()
        {
            Console.WriteLine("You Applied the Break");
        }

    }
    internal class Car
    {
        string name = Console.ReadLine();
        string wheels = Console.ReadLine();
        string brand = Console.ReadLine();
        string color = Console.ReadLine();
        static void move()
        {
            Console.WriteLine("Your Car is Moving");
        }
        static void accelarate()
        {
            Console.WriteLine("You accelarating the CAR");
        }
        static void breakk()
        {
            Console.WriteLine("You Applied the Break");
        }
    }
    internal class Scooter
    {
        string name = Console.ReadLine();
        string wheels = Console.ReadLine();
        string brand = Console.ReadLine();
        string model = Console.ReadLine();
        static void move()
        {
            Console.WriteLine("Your Scooter is Moving");
        }
        static void accelarate()
        {
            Console.WriteLine("You accelarating the Scooter");
        }
        static void breakk()
        {
            Console.WriteLine("You Applied the Break");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

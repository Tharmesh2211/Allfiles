using System;

namespace StaticClass
{
    public class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company Name   :  " + Bike.GetCompanyName());

            Bike.Display();
        }
    }

    public static class Bike
    {
        
        public static string CompanyName { get; set; } = "YAMAHA";
        public static int NoOfWheels { get; set; } = 2;
        public static string BikeName { get; set; } = "MT-15";
        public static string BikeColor { get; set; } = "Black";
        public static double BikeRate { get; set; } = 225000;

        static Bike()
        {
            Console.WriteLine("Welcome To Bike Class !\n");
        }
        
        public static void Display()
        {
            Console.WriteLine("Bike Name   :  "+BikeName);
            Console.WriteLine("Bike Color  :  "+BikeColor);
            Console.WriteLine("Bike Rate   :  "+BikeRate);
            Console.WriteLine("Bike Wheels :  "+NoOfWheels);
        }

        public static string GetCompanyName()
        {
            return CompanyName;
        }
    }
}

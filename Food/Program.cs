using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    internal class Program
    {
        static void assign(string hotelname, string foodname, int price)
        {
            Console.WriteLine("HOTEL NAME     : "+hotelname);
            Console.WriteLine("FOOD NAME      : "+foodname);
            Console.WriteLine("FOOD PRICE     : "+price);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Hotel Name    : ");
            string hotelname = Console.ReadLine();
            Console.Write("Enter Food Name     : ");
            string foodname = Console.ReadLine();
            Console.Write("Enter Food Price    : ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            assign(hotelname, foodname, price);
        }
    }
}

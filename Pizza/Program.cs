using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    internal class Program
    {
        static void GetValue(string pizzaname, string size, int price)
        {
            Console.WriteLine("Pizza Name    : "+pizzaname);
            Console.WriteLine("Pizza Size    : "+size);
            Console.WriteLine("Pizza Price   : "+price);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Pizza Name      : ");
            string pname = Console.ReadLine();
            Console.Write("Enter Pizza Size      : ");
            string size = Console.ReadLine();
            Console.Write("Enter Pizza Price     : ");
            int price =Convert.ToInt32( Console.ReadLine());
            Console.Clear();
            GetValue(pname, size, price);
        }
    }
}

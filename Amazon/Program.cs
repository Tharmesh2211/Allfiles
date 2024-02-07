using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    internal class Program
    {
        static void assign(string address, string location, long phonenumber, int pincode)
        {
            Console.WriteLine("Address      : "+address);
            Console.WriteLine("Location     : "+location);
            Console.WriteLine("Phone Number : "+phonenumber) ;
            Console.WriteLine("Pincode      : "+pincode);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Address       : ");
            string address = Console.ReadLine();
            Console.Write("Enter Location      : ");
            string location = Console.ReadLine();
            Console.Write("Enter Phone Number  : ");
            long phonenumber =Convert.ToInt64( Console.ReadLine());
            Console.Write("Enter Pincode       : ");
            int pincode = Convert.ToInt32( Console.ReadLine());
            Console.Clear();
            assign(address, location, phonenumber, pincode);
        }
    }
}

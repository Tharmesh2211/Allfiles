using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserEntry
{
    internal class Program
    {
        static void assign(string username, string password)
        {
            Console.WriteLine("User Name   : " + username);
            Console.WriteLine("Password    : "+password);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter User Name  : ");
            string username = Console.ReadLine();
            Console.Write("Enter Password   : ");
            string password = Console.ReadLine();   

            assign(username, password);
        }
    }
}

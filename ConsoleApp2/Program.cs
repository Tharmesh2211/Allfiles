using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int ID = 101;
            string Name = "Tharmesh";
            float Salary = 25000.32f;
            char Section = 'X';
            long PhoneNumber = 6383331480;
            bool isAvailable = true;
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("* * * * * * * * *    ABOUT YOU    * * * * * * * * *");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("*    ID             : "+ID+"                         *");
            Console.WriteLine("*    NAME           : "+Name + "                    *");
            Console.WriteLine("*    SECTION        : " + Section + "                           *");
            Console.WriteLine("*    SALARY         : " + Salary + "                    *");
            Console.WriteLine("*    PHONE NUMBER   : " + PhoneNumber + "                  *");
            Console.WriteLine("*    IS AVAILABLE ? : " + isAvailable + "                        *");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * *");

        }
    }
}

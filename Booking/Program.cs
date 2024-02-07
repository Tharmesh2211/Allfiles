using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    internal class Program
    {
        static void Assign(string tname, string pname, string berth, int age, long cno)
        {
            Console.WriteLine("TRAIN NAME     - " + tname);
            Console.WriteLine("PASSANGER NAME - "+pname);
            Console.WriteLine("BERTH          - "+berth);
            Console.WriteLine("AGE            - "+age);
            Console.WriteLine("CONTACT NUMBER - "+cno);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Train Name             : ");
            string tname = Console.ReadLine();
            Console.Write("Enter Passanger Name         : ");
            string pname = Console.ReadLine();
            Console.Write("Enter Berth Lwr / Uppr / mdl : ");
            string berth = Console.ReadLine();
            Console.Write("Enter Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Contact Number         : ");
            long cno  = Convert.ToInt64(Console.ReadLine());
            Console.Clear();
            Assign(tname, pname, berth, age, cno);

        }
    }
}

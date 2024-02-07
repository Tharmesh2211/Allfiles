using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    internal class Program
    {
        static void assign(string mname, string tname, string datetime, int seatno)
        {
            Console.WriteLine("Movie Name       : "+mname);
            Console.WriteLine("Theatre Name     : "+tname);
            Console.WriteLine("Show Date & Time : "+datetime);
            Console.WriteLine("Seat Number      : "+seatno);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Movie Name       : ");
            string Mname = Console.ReadLine();
            Console.Write("Enter Theatre Name     : ");
            string Tname = Console.ReadLine();
            Console.Write("Enter Show Date & Time : ");
            string DateTime = Console.ReadLine();
            Console.Write("Enter Seat Number      : ");
            int seatno = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            assign(Mname, Tname, DateTime, seatno);
        }
    }
}

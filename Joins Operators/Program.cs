using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joins_Operators
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================");
            ProgramMain.InnerJoin();
            Console.WriteLine("========================");
            ProgramMain.LeftJoin();
            Console.WriteLine("========================");
            ProgramMain.RightJoin();
            Console.WriteLine("========================");
            ProgramMain.CrossJoin();
            Console.WriteLine("========================");

        }
    }
}

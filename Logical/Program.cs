using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=10; int y=10,z=40;
           
            bool check = ((x == y )&& (y == z));
            Console.WriteLine(check);

            z = 10;
            check = ((x == z) && (y == x));
            Console.WriteLine(check);

            x = 30;
            check  = (((x == y) && (y == z)) && (z == x));
            Console.WriteLine(check);

            z = 30;
            check = (x == y) || (z == x);
            Console.WriteLine(check);
            
            check = ((y == z) || (y == x));
            Console.WriteLine(check);

            check = !(x == y);
            Console.WriteLine(check);

            check &= !(z == x);
            Console.WriteLine(check);
        }
    }
}

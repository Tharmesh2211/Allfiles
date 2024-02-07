using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5; int y=10;
            bool check = (x == y);
            Console.WriteLine(check);
            
            y = 5;
            check = (x == y);
            Console.WriteLine(check);
            
            x = 10;
            check = (x!= y);
            Console.WriteLine(check);
            
            y = 10;
            check = (x!= y);
            Console.WriteLine(check);

            x=12; y=1;
            check = (x> y);
            Console.WriteLine(check);

            x = 1;
            check = (x> y);
            Console.WriteLine(check);

            y = 50;
            check = (x< y);
            Console.WriteLine(check);
            
            y = 1;
            check = (x>= y);
            Console.WriteLine(check);

            x = 5;y = 9;
            check = (x<= y);
            Console.WriteLine(check);
        }
    }
}

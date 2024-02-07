using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                                                                        // Find Big of 2 nos
                /*
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("X is Big " + x);
            }
            else
            {
                Console.WriteLine("Y is Big " + y);
            }*/

                                                                                        // Find a Person in Eligible for Voting

            /*int x = Convert.ToInt32(Console.ReadLine());
            if (x >18)
            {
                Console.WriteLine("He is Eligible For Voting");
            }
            else
            {
                Console.WriteLine("He is Not Eligible For Voting");
            }*/

                                                                                                     //Find a no is ODD or EVEN
            /*int x = Convert.ToInt32(Console.ReadLine());
            bool y = (1 == x % 2);
            if(y)
            {
                Console.WriteLine("ODD Number");
            }
            else
            {
                Console.WriteLine("EVEN Number");
            }*/

                                                                                                    //Find a number +ve or -ve
            /*int x = Convert.ToInt32(Console.ReadLine());
            if (x>0)
            {
                Console.WriteLine("Positive Number");
            }
            else
            {
                Console.WriteLine("Negative  Number");

            }*/
                                                                                                //Find Diff b/w 2 nos
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            
            if (x > y)
            {
                Console.WriteLine("x > y = "+(x-y));
            }
            else
            {
                Console.WriteLine("y > x = " + (y - x));
            }
            Console.ReadKey();

        }
    }
}

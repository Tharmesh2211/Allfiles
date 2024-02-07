using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find a number is 2digit or not 

            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 9)
            {
                if (x < 100)
                {
                    Console.WriteLine("2 Digit Number ");
                }
                else
                {
                    Console.WriteLine("Not A 2 Digit Number");
                }
            }
            else
            {
                Console.WriteLine("Not A 2 Digit Number");
            }

            // Check username and Password

            /*string name = Console.ReadLine();
            string password = Console.ReadLine();
            if(name.Equals("Tharmesh"))
            {
                if(password.Equals("Tharmesh@123"))
                {
                    Console.WriteLine("Successfully Logged In");
                }
                else { 
                    Console.WriteLine("Incorrect Password");
                }
            }
            else
            {
                    Console.WriteLine("Incorrect User Name");
            }*/

            //Find a Year Leap or Not

            /*int x = Convert.ToInt32(Console.ReadLine());
            if(x%4== 0)
            {
                if(x%100!=0)
                {
                    Console.WriteLine("Leap Year");
                }
                else
                {
                    Console.WriteLine("Not Leap Year");
                }
            }
            else 
            { 
                Console.WriteLine("Not A Leap Year"); 
            }*/

            // check Both number is +ve or not

            /*int x = Convert.ToInt32(Console.ReadLine());    
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("Both are Positive Number");
                }
                else
                {
                    Console.WriteLine("2nd Number is Not Positive");
                }
            }
            else
            {
                Console.WriteLine("1st Number is Not Positive");
            }*/

            // Find a Number 3 digit or not

            //int x = Convert.ToInt32(Console.ReadLine());
            //if (x > 99)
            //{
            //    if (x < 1000)
            //    {
            //        Console.WriteLine("3 Digit Number ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not A 3 Digit Number");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Not A 3 Digit Number");
            //}

            Console.ReadKey();

        }
    }
}

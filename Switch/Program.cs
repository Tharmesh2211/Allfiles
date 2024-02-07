using System;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input code find value
            //int x = int.Parse(Console.ReadLine());
            //switch (x)
            //{
            //    case 1:
            //        Console.WriteLine("Electrical");
            //        break;
            //    case 2:
            //        Console.WriteLine("Hospital");
            //        break;
            //    case 3:
            //        Console.WriteLine("School");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid");
            //        break;
            //}

            //Input char find vowel
            /*char x = char.Parse(Console.ReadLine());
            switch (x)
            {
                case 'a': Console.WriteLine("Vowel");
                    break;
                case 'e': Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
               default: Console.WriteLine("Not A Vowel");
                    break;
            }*/

            Console.Write("Enter Month Number  :  ");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("January 31 Days 2023");
                    break;
                case 2:
                    Console.WriteLine("February 28 Days 2023");
                    break;
                case 3:
                    Console.WriteLine("March 31 Days 2023");
                    break;
                case 4:
                    Console.WriteLine("April 30 Days 2023");
                    break;
                case 5:
                    Console.WriteLine("May 31 Days 2023");       //input month number print month name and possible days
                    break;
                case 6:
                    Console.WriteLine("June 30 Days 2023");
                    break;
                case 7:
                    Console.WriteLine("July 31 Days 2023");
                    break;
                case 8:
                    Console.WriteLine("August 31 Days 2023");
                    break;
                case 9:
                    Console.WriteLine("September 30 Days 2023");
                    break;
                case 10:
                    Console.WriteLine("October 31 Days 2023");
                    break;
                case 11:
                    Console.WriteLine("November 30 Days 2023");
                    break;
                case 12:
                    Console.WriteLine("December 31 Days 2023");
                    break;
                default:
                    Console.WriteLine("Invalid Month Number");
                    break;
            }
            //Calculator in switch





            //Console.WriteLine("Enter no 1 : ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter no 2 : ");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Option :\n1. ADD \n2.SUB \n3. Multiply \n4. Divide");
            //int z = int.Parse(Console.ReadLine());
            //switch (z)
            //{
            //    case 1:
            //        Console.WriteLine("Addition of 2 number : " + (x + y));
            //        break;
            //    case 2:
            //        Console.WriteLine("Substraction of 2 number : " + (x - y));
            //        break;
            //    case 3:
            //        Console.WriteLine("Multiple of 2 numbers : " + (x * y));
            //        break;
            //    case 4:
            //        Console.WriteLine("Division of 2 numbers : " + (x / y));
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Code");
            //        break;
            //}
            //input day no find day



            /*int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:Console.WriteLine("Monday");
                    break;
                case 2:Console.WriteLine("Tuesday");
                    break;
                case 3:Console.WriteLine("Wednesday");
                    break;
                case 4:Console.WriteLine("Thursday");
                    break;
                case 5:Console.WriteLine("Friday");
                    break;
                case 6:Console.WriteLine("Saturday");
                    break;
                case 7:Console.WriteLine("Sunday");
                    break;
                default:Console.WriteLine("Error Day Number");
                    break;
            }
            */
            Console.ReadKey();

        }
    }
}

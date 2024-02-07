using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                                                                //Biggest of 3 numbers
            /*int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            if(x>y)
            {
                if(x>z)
                {
                    Console.WriteLine("X is Big");
                }
                else
                {
                    Console.WriteLine("Z is Big");
                }
            }
            else if(y>z)
            {
                Console.WriteLine("Y is Big");
            }
            else 
            { 
                Console.WriteLine("Z is Big"); 
            }*/

                                                                                    //Find Discount 
            
            /*int amount = Convert.ToInt32(Console.ReadLine());
            float discount;
            if (amount < 500) 
            {
                discount = amount * 0.20f;
            }
            else if (amount < 1000)
            {
                discount = (amount * 0.10f);
            }
            else
            {
                discount = amount * 0.30f;
            }
            Console.WriteLine("Discount of {0} is {1}",amount, discount);*/

            
                                                                                    //Find GM / GE / GA/ GN
            
            /*int time = int.Parse(Console.ReadLine());
            if(time<12)
            {
                Console.WriteLine("Good Morning");
            }
            else if(time<15)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if(time < 18)
            {
                Console.WriteLine("Good Evening");
            }
            else if(time < 24)
            {
                Console.WriteLine("Good Night");
            }
            else
            { Console.WriteLine("Error Time"); }*/

                                                                   //Input Age find paalvaadi primary / higher secondary/ college
            
            /*int age = int.Parse(Console.ReadLine());
            if(age>3 && age <7)
            {
                Console.WriteLine("Going to PAALVAADI");
            }
            else if(age <=15) 
            {
                Console.WriteLine("PRIMARY SCHOOL");
            }
            else if(age <=17)
            { 
                Console.WriteLine("Higher Secondary School");
            }
            else if(age<21||age<22)
            {
                Console.WriteLine("College");
            }
            else { Console.WriteLine("OTHERS"); 
            }*/
                                                                    //input SSLC total Print class

            int total = int.Parse(Console.ReadLine());
            if (total < 175)
            {
                Console.WriteLine("Fail");
            }
            else if(total <250)
            {
                Console.WriteLine("Third Class");
            }
            else if(total <350)
            {
                Console.WriteLine("Second Class");
            }
            else
            {
                Console.WriteLine("First Class");
            }

            Console.ReadKey();
        }
    }
}

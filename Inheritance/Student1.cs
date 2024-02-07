using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Student1
    {
        public  static int Id { get; set; } 
        public  static string Name { get; set; }
        public  static int Age { get; set; }
        public  static long PhoneNumber { get; set; }
        public Student1() 
        {
            Console.WriteLine("Executing Constructor 1 !!");
        }
        public static void Assign(int id, string name, int age, long phoneNumber)
        {

            Id = id;
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
        }

        public static void PrintStudent1()
        {
            Assign(11, "Tharmesh", 21, 9081743265);

            Console.WriteLine("Student Name           : " + Name);
            Console.WriteLine("Student ID             : " + Id);
            Console.WriteLine("Student Age            : " + Age);
            Console.WriteLine("Student PhoneNumber    : " + PhoneNumber);
        }
    }

    public class Student2 : Student1
    {
        public static int Mark1 { get; set; }
        public static int Mark2 { get; set; }
        public static int Mark3 { get; set; }
        public static int Mark4 { get; set; }
        public static int Mark5 { get; set; }
        
        public Student2()
        {
            Console.WriteLine("Executing Constructor 2 !!");
        }

        public static void AssignMark(int mark1, int mark2,int mark3, int mark4, int mark5)
        {

            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
            Mark4 = mark4;
            Mark5 = mark5;
        }
        
        public static void PrintStudent2()
        {
            PrintStudent1();
            AssignMark(78, 98, 86, 66, 91);

            Console.WriteLine("Mark 1    : " + Mark1);
            Console.WriteLine("Mark 2    : " + Mark2);
            Console.WriteLine("Mark 3    : " + Mark3);
            Console.WriteLine("Mark 4    : " + Mark4);
            Console.WriteLine("Mark 5    : " + Mark5);
        }
    }

    public class Student3 : Student2
    {
        public static int Total { get; set; }
        public static float Average { get; set; }
        public static bool Result { get; set; }

        public Student3()
        {
            Console.WriteLine("Executing Constructor 3 !!");
        }
        public static void Calculation()
        {
            Total = Mark1 + Mark2 + Mark3 + Mark4 + Mark5;
            Average = Total / 5.0f;
            if (Mark1 >= 35 && Mark2 >= 35 && Mark3 >= 35 && Mark4 >= 35 && Mark5 >= 35)
            {
                Result = true;
            }
            else
            {
                Result = false;
            }
        }

        public static void PrintStudent3()
        {
            PrintStudent2();
            Calculation();
            Console.WriteLine("Student Total   : " + Total);
            Console.WriteLine("Student Average : " + Average);
            Console.WriteLine("Student Result  : "+Result);
        }
    }
}

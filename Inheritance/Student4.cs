using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Student
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static int Age { get; set; }
        public static long PhoneNumber { get; set; }
        public Student()
        {
            Console.WriteLine("Executing Constructor 1 !!");
        }
        public void AssignValue(int id, string name, int age, long phoneNumber)
        {
            Id = id;
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
        }

        public void Printvalue()
        {

            Console.WriteLine("Student Name           : " + Name);
            Console.WriteLine("Student ID             : " + Id);
            Console.WriteLine("Student Age            : " + Age);
            Console.WriteLine("Student PhoneNumber    : " + PhoneNumber);
        }
    }

    public class Mark : Student
    {
        public static int Mark1 { get; set; }
        public static int Mark2 { get; set; }
        public static int Mark3 { get; set; }
        public static int Mark4 { get; set; }
        public static int Mark5 { get; set; }

        public Mark()
        {
            Console.WriteLine("Executing Constructor 2 !!");
        }

        public void AssignMark(int mark1, int mark2, int mark3, int mark4, int mark5)
        {

            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
            Mark4 = mark4;
            Mark5 = mark5;
        }

        public void PrintMark()
        {

            Console.WriteLine("Mark 1    : " + Mark1);
            Console.WriteLine("Mark 2    : " + Mark2);
            Console.WriteLine("Mark 3    : " + Mark3);
            Console.WriteLine("Mark 4    : " + Mark4);
            Console.WriteLine("Mark 5    : " + Mark5);
        }
    }

    public class Calculate : Mark
    {
        public static int Total { get; set; }
        public static float Average { get; set; }
        public static bool Result { get; set; }

        public Calculate()
        {
            Console.WriteLine("Executing Constructor 3 !!");
        }
        public void Calculation()
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

        public void PrintCalculation()
        {
            Console.WriteLine("Student Total   : " + Total);
            Console.WriteLine("Student Average : " + Average);
            Console.WriteLine("Student Result  : " + Result);
        }
    }
}

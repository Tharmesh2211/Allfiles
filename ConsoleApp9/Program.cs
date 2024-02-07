using System;
namespace Topics
{
    public class Student
    {
        string Name = "";
           int ID = 0;
          long phonenumber = 0;
           int Mark1 = 0;
           int Mark2 = 0;
           int Mark3 = 0;

        public void InputData()
        {
            // Here I'm getting all the Inputs of a Student (name, ID, mark1, mark2, mark3) 

            Console.Write("Enter Student Name   : ");
            Name = Console.ReadLine();

            Console.Write("Enter Student ID     : ");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student PhoneNumber : ");
            phonenumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter Student Mark 1 : ");
            Mark1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Mark 2 : ");
            Mark2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Mark 3 : ");
            Mark3 = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintDetails()
        {
            // Here the PrintDetails Function Prints all the Values of a Student

            Console.WriteLine("Student Name : " + Name);
            Console.Write("Student ID   : " + ID);
            Console.WriteLine("Student PhoneNumber : " + phonenumber);
            Console.WriteLine("Student Mark 1      : " + Mark1);
            Console.WriteLine("Student Mark 2      : " + Mark2);
            Console.WriteLine("Student Mark 3      : " + Mark3);
        }
        static void Main(string[] args)
        {

        }
    }

}





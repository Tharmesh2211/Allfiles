using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    public class Student : CommonData
    {
        public string Name { get; }
        public int Id { get; }
        public int Age { get; }
        public DateTime DOB { get; }
        public long PhoneNumber { get; }
        public Student(int Id, string Name, int Age, long PhoneNumber, DateTime DOB) 
        { 
            
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.PhoneNumber = PhoneNumber;
            this.DOB = DOB;
        }
        public void PrintData()
        {
            Console.WriteLine("Student ID  : "+Id);
            Console.WriteLine("Student Name  : "+Name);
            Console.WriteLine("Student Age  : "+Age);
            Console.WriteLine("Student Phone Number  : "+PhoneNumber);
            Console.WriteLine("Student Date Of Birth  : "+DOB);
        }
        public void Calculate()
        {

        }
    }
}

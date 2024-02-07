using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public DateTime dateTime { get; set; }
        public Employee()
        {
            Console.WriteLine("I'm From Employee Constructor!!");
        }
        public Employee(string name, int age, decimal salary, DateTime datetime)
        {
            Name = name;
            Age = age;
            Salary = salary;
            dateTime = datetime;
        }

        public void Print()
        {
            Console.WriteLine("Name      : " + Name);
            Console.WriteLine("Age       : " + Age);
            Console.WriteLine("Salary    : " + Salary);
            Console.WriteLine("Date Of Birth  : " + dateTime.ToString("yyyy-MM-dd"));
        }
    }
}

using System;

namespace ConsoleApp2
{
    public abstract class Employee
    {
        public string Name {  get; set; }
        public decimal Salary {  get; set; }
        public DateTime DOB { get; set; }
        public string Gender {  get; set; }
        public long Contact {  get; set; }

        public Employee(string name, decimal salary, DateTime dOB, string gender, long contact)
        {
            Name = name;
            Salary = salary;
            DOB = dOB;
            Gender = gender;
            Contact = contact;
        }

        public abstract void DisplayDetails();
    }
}

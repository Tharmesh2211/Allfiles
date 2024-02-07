using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Person
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender {  get; set; }
        public long ContactNumber {  get; set; }

        public Person(string firstName, string lastName, int age, string gender, long contactNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            ContactNumber = contactNumber;
        }

        public abstract void DisplayDetails();

    }
}

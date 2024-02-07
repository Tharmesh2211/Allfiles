using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployRegistration
{
    internal class Program
    {
        public string EmployeeId { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public bool IsRegistered { get; set; }
        static void Main(string[] args)
        {
        }
    }
}

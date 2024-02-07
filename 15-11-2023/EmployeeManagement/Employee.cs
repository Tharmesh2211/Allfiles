using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Employee
    {
        public int EmployeetID { get; set; }
        public string EmployeeName {  get; set; }
        public DateTime DOB {  get; set; }
        public string Gender {  get; set; }
        public long PhoneNumber {  get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public double Salary {  get; set; }
    }
}

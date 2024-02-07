using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Employ
    {
        public int Emp_ID {  get; set; }
        public string Emp_Name { get; set; }
        public DateTime Dob {  get; set; }
        public double Salary { get; set; }
        public double HRA { get; set; }
        public double Tax { get; set; }
        public double AnnualIncome {  get; set; }

        public Employ(int emp_ID, string emp_Name, DateTime dob, double salary)
        {
            Emp_ID = emp_ID;
            Emp_Name = emp_Name;
            Dob = dob;
            Salary = salary;
           
        }
    }
}

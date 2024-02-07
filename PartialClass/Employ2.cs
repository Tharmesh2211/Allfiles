using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Employ : IEmploy
    {
        public void Calculate()
        {
            HRA = Salary * 0.05;
            Tax = Salary * 0.03;

            AnnualIncome = (Salary + HRA + Tax) * 12;
        }

        public void Display()
        {
            Console.WriteLine("Employ ID     :  "+Emp_ID);
            Console.WriteLine("Employ Name   :  "+Emp_Name);
            Console.WriteLine("Employ DOB    :  "+(Dob.ToString("dd-MM-yyyy")));
            Console.WriteLine("Employ Salary  :  " + Salary);
            Console.WriteLine("Employ HRA    :  "+HRA);
            Console.WriteLine("Employ Tax    :  "+Tax);
            Console.WriteLine("Employ Annual Income   :  "+AnnualIncome);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    interface IExtraInfo
    {
        double HRA {  get; set; }
        double DA { get; set; }
        double Tax { get; set; }
        double Salary { get; set; }
        double TotalSalary {  get; set; }
        void Calculate();
        void PrintData();
    }
}

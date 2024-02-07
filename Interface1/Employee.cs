using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interface1
{
    internal class Employee:ICommonData,IExtraInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age {  get; set; }
        public long PhoneNumber {  get; set; }
        public double HRA { get; set; }
        public double DA { get; set; }
        public double Tax { get; set; }
        public double Salary { get; set; }
        public double TotalSalary {  get; set; }
        public DateTime DOB { get; set; }

        public Employee(int Id, string Name, int Age, long PhoneNumber, DateTime DOB,double Salary) 
        {      
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.PhoneNumber = PhoneNumber;
            this.DOB = DOB;
            this.Salary = Salary;
        }
        void IExtraInfo.Calculate()
        {
            HRA = Salary * 0.02;
            DA = Salary * 0.03;
            Tax = Salary * 0.04;
            TotalSalary = Salary + HRA + DA - Tax;
        }
        void IExtraInfo.PrintData()
        {
            Console.WriteLine("Employee ID  : "+Id);
            Console.WriteLine("Employee Name  : " + Name);
            Console.WriteLine("Employee Age  : "+Age);
            Console.WriteLine("Employee PhoneNumber  : "+PhoneNumber);
            Console.WriteLine("Employee Date Of Birth  : " + DOB);
            Console.WriteLine("House Rent Allowance (HRA)  : " + HRA);
            Console.WriteLine("Dearness Allowance (DA)  : " + DA);
            Console.WriteLine("Tax    :  "+Tax);
            Console.WriteLine("Total Salary  : "+TotalSalary);
        }
        void ICommonData.Calculate() { }
        void ICommonData.PrintData() { }
    }
}

using System;

namespace ConsoleApp2
{
    public class Worker2 : Worker,IWorker
    { 
        public string Department {  get; set; }

        public Worker2(string Name, decimal Salary, DateTime DOB, string Gender, long Contact, int WorkerID, string Depart) 
                : base(Name, Salary, DOB, Gender, Contact, WorkerID)
        {
            Department = Depart;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Department    :  "+Department);
        }
    }
}

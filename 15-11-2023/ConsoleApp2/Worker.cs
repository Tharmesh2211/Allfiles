using System;

namespace ConsoleApp2
{
    public class Worker : Employee, IWorker
    {
        public int WorkerID {  get; set; }
        public Worker(string Name, decimal Salary, DateTime DOB, string Gender, long Contact, int WorkerID)
                    :base(Name,Salary,DOB, Gender,Contact)
        {
           
            this.WorkerID = WorkerID;
        }

        public override void DisplayDetails()
        {
            string Value = "Name  : " + Name + " Salary  : " + Salary + "  DOB  : " 
                + DOB.ToString("dd-MM-yyyy") + "  Gender  : " + Gender + "  Contact  :  " + Contact;

            Console.WriteLine(Value);
        }
        public void Dispatch()
        {
            Console.WriteLine("Dispatched Successfully !!");
        }

        public void Enrollment()
        {
            Console.WriteLine("Enrolled Successfully !!");
        }

        public int GetWorkerID()
        {
            return WorkerID;
        }
    }
}

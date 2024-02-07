using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Worker2 worker2 = new Worker2("Tharmesh", 100000, new DateTime(2002,11,22), "Male", 9087654321, 200,"Developer");
            worker2.Enrollment();
            worker2.Dispatch();
            Console.WriteLine("Worker ID  :  "+worker2.GetWorkerID());
            worker2.DisplayDetails();
        }
    }
}


 

 
 



 

 

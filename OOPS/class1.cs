using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Employ
    {
       public string Name {  get; set; }
        public int Id { get; set; }
        public long Salary {  get; set; }

        public void Print()
        {
            Console.WriteLine("Name   : "+ " " +Name);
            Console.WriteLine("ID     : "+Id);
            Console.WriteLine("Salary : " + Salary);
        }
    }
}

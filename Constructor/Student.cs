using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mark1 {  get; set; }
        public int Mark2 { get; set; }
        public int Mark3 {  get; set; }
        public int Total {  get; set; }
        public float Average {  get; set; }
        public Student(int Id, string Name, int Mark1, int Mark2, int Mark3) 
        {
            this.Name = Name;
            this.Id = Id;
            this.Mark1 = Mark1;
            this.Mark2 = Mark2;
            this.Mark3 = Mark3;

        }
        public void Calculation ()
        {
            Total = Mark1 + Mark2 + Mark3;
            Average = Total / 3.0f;
        }
        public void Display()
        {
            Console.WriteLine("Student Name    : "+Name);
            Console.WriteLine("Student ID      : " + Id);
            Console.WriteLine("Student Mark 1  : "+Mark1);
            Console.WriteLine("Student Mark 2  : " + Mark2);
            Console.WriteLine("Student Mark 3  : " + Mark3);
            Console.WriteLine("Student Total   : "+Total);
            Console.WriteLine("Student Average : " + Average);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Car : IDriveable
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public Car(int year, string Name)
        {
            Year = year;
            this.Name = Name;
        }
        public void Start()
        {
            Console.WriteLine(Name + " Engine Started in " + Year);
        }
        public void Stop()
        {
            Console.WriteLine(Name + " Engine Stopped in " + Year);
        }
    }

}

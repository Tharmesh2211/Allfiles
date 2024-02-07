using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class AeroPlane : IDriveable, IFlayable
    {
        public int Year { get; set; }
        public string Name { get; set; }

        public AeroPlane(int Year, String Name) 
        { 
            this.Year = Year;
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

        public void TakeOff()
        {
            Console.WriteLine(Name + " AeroPlane Taking Off");
        }
        public void Land()
        {
            Console.WriteLine(Name + " AeroPlane Landing");
        }
    }

}

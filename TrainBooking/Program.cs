using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBooking
{
    internal class Program
    {
        public string from {  get; set; }
        public string to { get; set; }
        public string all_classes {  get; set; }
        public DateTime Datetime { get; set; }
        public string general { get; set; }

        static void Main(string[] args)
        {
        }
       
    }
    public enum all_classes
    {
        First_Class,
        Second_Class,
        Third_Class,
        Normal
    }
}

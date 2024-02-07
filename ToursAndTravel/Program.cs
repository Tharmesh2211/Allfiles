using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToursAndTravel
{
    internal class Program
    {
        public int ID {  get; set; }
        public string BookingId { get; set; }
        public string TravelerName { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int NumberOfTravelers { get; set; }
        public decimal TotalCost { get; set; }
        public bool IsConfirmed { get; set; }
        static void Main(string[] args)
        {
        }
    }
}

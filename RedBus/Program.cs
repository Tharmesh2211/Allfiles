using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBus
{
    internal class Program
    {
        public string BookingId { get; }
        public string PassengerName { get; set; }
        public string BusName { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public bool IsConfirmed { get; set; }

        static void Main(string[] args)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking
{
    internal class Program
    {
        public string BookingId { get; }
        public string GuestName { get; set; }
        public string HotelName { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfGuests { get; set; }
        public decimal TotalCost { get; set; }
        public bool IsConfirmed { get; set; }
        static void Main(string[] args)
        {
        }
    }
}

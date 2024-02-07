
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway_Ticket_Booking
{
    public class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train(100, "Muthunagae Express", 24);
            Passenger passenger1 = new Passenger(101, "Sairam", 9087654321, "Ub");
            Booking booking = new Booking(train, passenger1);
            booking.SetTrainClass(train);
            booking.SetPassengerClass(passenger1);
            booking.ReservationLogic();
            booking.Display();

            Console.ReadKey();
            Console.Clear();

            Passenger passenger2 = new Passenger(102, "tharmesh", 8901234567, "lb");
            Booking booking2 = new Booking(train, passenger2);

            booking2.SetPassengerClass(passenger2);

            booking2.ReservationLogic();
            booking2.Display();

            Console.ReadKey();
            Console.Clear();

            booking2.ReadPassenger();
        }
    }
}

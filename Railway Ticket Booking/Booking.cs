using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Railway_Ticket_Booking
{
    public class Booking 
    {
        private ITrain itrain1, itrain2;

        private static Train train;

        private static Passenger passenger;

        public static List<Passenger> passes = new List<Passenger>();
        public Booking( ITrain itrain1, ITrain itrain2) 
        {
            this.itrain1 = itrain1;
            this.itrain2 = itrain2;
           
        }

        public void SetTrainClass(Train trains)
        {
            train = trains;
        }
        public void SetPassengerClass( Passenger passengers)
        {
            passenger = passengers;

        }

        public void ReservationLogic()
        {
            itrain1.Print();

            if ((passenger.Berth).ToUpper().Equals("UB"))
            {
                train.UpperBerth --;
            }
            else if ((passenger.Berth).ToUpper().Equals("LB"))
            {
                train.LowerBerth --;
            }
            else if ((passenger.Berth).ToUpper().Equals("MB"))
            {
                train.MiddleBerth --;
            }

            train.TotalSeat--;

            passes.Add(passenger);

            itrain2.Print();

        }

        public void Display()
        {

            Console.WriteLine("\n============== After Booking The Tickets ==============\n");
            Console.Write("Train No    :  " + train.TrainNo + "    TotalSeat    :  " + train.TotalSeat);
            Console.WriteLine("     Upper Berth   :  " + train.UpperBerth + "    Lower Berth   :  " + train.LowerBerth +"     Middle Berth   :   " + train.MiddleBerth+"\n");
        }
        
        public void ReadPassenger()
        {
            Console.WriteLine("\n\tReading ALl the Passenger ....!!\n");
            foreach (var passenger in passes)
            {
                Console.WriteLine("ID     :  " + passenger.Id + "   Name   :  " + passenger.Name + "     Contact     :   " + passenger.PhoneNo + "   Berth   :  " + passenger.Berth);
            }
        }

            
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway_Ticket_Booking
{
    public class Passenger : ITrain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long PhoneNo {  get; set; }
        public string Berth {  get; set; }

        public Passenger(int id, string name, long phoneNo, string berth)
        {
            Id = id;
            Name = name;
            PhoneNo = phoneNo;
            Berth = berth;
        }

        public void Print()
        {
            Console.WriteLine("ID     :  "+Id+"   Name   :  "+Name+"     Contact     :   "+PhoneNo +"   Berth   :  "+Berth);
        }
    }
}

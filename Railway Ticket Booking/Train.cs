using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway_Ticket_Booking
{
    public class Train : ITrain
    {
       public string TrainName { get; set; }
        public int TrainNo { get; set;}
        public int TotalSeat { get; set; }
        public int LowerBerth { get; set; }
        public int UpperBerth { get; set; }
        public int MiddleBerth { get; set; }


        public Train(int TrainNo, string TrainName, int TotalSeat) 
        { 
            this.TrainNo = TrainNo;
            this.TrainName = TrainName; 
            this.TotalSeat = TotalSeat;
            LowerBerth = this.TotalSeat/3;
            UpperBerth = this.TotalSeat/3;
            MiddleBerth = this.TotalSeat/3;
        }
       
        public void Print()
        {
            Console.Write("Train Name    :  " + TrainName + "       Train No    :  " + TrainNo + "    TotalSeat    :  " + TotalSeat);
            Console.WriteLine("     Upper Berth   :  " + UpperBerth + "    Lower Berth   :  " + LowerBerth + "     Middle Berth   :   " + MiddleBerth + "\n");
        }
    }
 
}

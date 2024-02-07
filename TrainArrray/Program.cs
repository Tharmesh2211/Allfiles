using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainArrray
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] trainname = { "muthunagar", "Rockfort", "Sahapti" };
            int[] Count = { 240, 120, 100 };
            bool check = true;
            Console.WriteLine("Enter Train Name  :  ");
            string train = Console.ReadLine();
            for(int i = 0; i < trainname.Length; i++)
            {
                if (train.Equals(trainname[i]))
                {
                    check = false;
                    Console.WriteLine("Ticket Count in {0} Train is {1}", trainname[i], Count[i]);
                    break;
                }
            }
            if(check)//flase
            {
                Console.WriteLine("No Train Name Found!");
            }
        }
    }
}

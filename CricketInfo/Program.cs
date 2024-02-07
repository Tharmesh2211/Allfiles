using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketInfo
{
    internal class Program
    {
        static void Team(int score, string player1, string player2, string country = "INDIA")
        {
            Console.WriteLine("{0} Scored {1} Runs ",country,score);
            Console.WriteLine("{0} and {1} are Bating\n\n",player1 , player2);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Score    : ");
            int score = Convert.ToInt32(Console.ReadLine());
            Team(score,"Dinesh","Ravi");
            Team(200, "Dinesh", "Ravi");
            Team(score, "Kelvin", "Rajan", "England");
            
        }
    }
}

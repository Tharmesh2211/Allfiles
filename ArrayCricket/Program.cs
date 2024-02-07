using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCricket
{
    internal class Program
    {
        public static void While(string[] arraycricket)
        {
            Console.WriteLine("Executing While Loop");
            int i = 0;
            while (i < arraycricket.Length)
            {
                Console.WriteLine("Cricket Player {0} - {1}", i + 1, arraycricket[i]);
                i++;
            }
        }

        public static void DoWhile(string[] arraycricket)
        {
            Console.WriteLine("Executing Do-While Loop");
            int i = 0;
            do
            {
                Console.WriteLine("Cricket Player {0} - {1}", i + 1, arraycricket[i]);
                i++;
            }
            while (i < arraycricket.Length);
        }
        static void Main(string[] args)
        {
            string[] arraycricket = {"Virat","Dhoni", "Ashwin", "Dinesh", "Rohit", "KL Rahul", "Kuldeep", "Suryakumar", "Jaddu", "Bumrah","Pandya"};
          
            While(arraycricket);
            Console.WriteLine("-----------------------------");
            DoWhile(arraycricket);
            
        }
    }
    
}

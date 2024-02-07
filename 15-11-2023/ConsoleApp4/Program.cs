using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransactionList list = new TransactionList();
            List<Transaction> transactionList = list.Create();
            Console.WriteLine("====================================");
            list.Read(transactionList);
            Console.WriteLine("====================================");
            //list.Delete(transactionList);   
            list.SoftDelete(transactionList);
            Console.WriteLine("====================================");
            list.Read(transactionList);
            Console.WriteLine("====================================");
        }
    }
}

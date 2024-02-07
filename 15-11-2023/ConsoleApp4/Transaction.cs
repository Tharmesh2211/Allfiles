using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Transaction
    {
        public static int Id { get; set; } = 100;
        public string Name { get; set; }
        public bool IsCheck {  get; set; }
    }

    public class TransactionList
    {

        public List<Transaction> Create()
        {
            List<Transaction> list = new List<Transaction>()
            {
                new Transaction() {Name = "tharmesh",IsCheck = true},
                new Transaction() {Name = "Sairam",IsCheck = true}
            };
            return list;
        }
        public void Read(List<Transaction> list)
        {
            foreach(var item in list)
            {
                if(item.IsCheck)
                Console.WriteLine("ID   : "+Transaction.Id+"  Name   : "+item.Name+ "  IsCheck  : "+ item.IsCheck);
            }
        }
        public void Delete(List<Transaction> list)
        {
            try
            {
                Console.Write("Enter ID To Delete   :  ");
                int id = int.Parse(Console.ReadLine());

                foreach (var item in list)
                {
                    if (Transaction.Id == id)
                        list.Remove(item);
                    Console.WriteLine("Removed Successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void SoftDelete(List<Transaction> list)
        {
            try
            {
                Console.Write("Enter ID To Delete   :  ");
                int id = int.Parse(Console.ReadLine());

                foreach (var item in list)
                {
                    if (Transaction.Id == id)
                    {
                        item.IsCheck = false;
                        Console.WriteLine("Removed Successfully");
                    }
                       
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

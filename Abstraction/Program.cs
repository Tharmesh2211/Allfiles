using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{

    public abstract class Bank
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount {  get; set; }
        public Bank(int Id, string Name) 
        { 
            this.Id = Id;
            this.Name = Name;
        }
        public abstract int Deposit(int Amount);
        public abstract int Withdraw(int Amount);
        public abstract void PrintAccountDetails();
        public void BalanceCheck()
        {
            Console.WriteLine("Balance in your Account : " + Amount);
        }
        
    }

    public class Account:Bank
    {
        public Account(int Id, string Name):base(Id,Name)
        {
            this.Id= Id;
            this.Name= Name;
        }

        public override void PrintAccountDetails()
        {
            Console.WriteLine("Accounter ID : "+Id);
            Console.WriteLine("Accounter Name : "+Name);
        }

        public override int Deposit(int Amount)
        {
           
            this.Amount += Amount;
            return this.Amount;
        }
        public override int Withdraw(int Amount)
        {
            if(this.Amount > Amount)
            {
                this.Amount -=Amount;
                return this.Amount;
            }
            Console.WriteLine("Insufficient Amount!!");
            return 0;
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Account account = new Account(5,"Tharmesh");
            account.Deposit(1000);
            account.Withdraw(500);
            account.Withdraw(300);
            account.PrintAccountDetails();
            account.BalanceCheck();
        }
    }
}

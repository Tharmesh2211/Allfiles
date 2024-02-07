using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB_BillManagement
{
    public class Customer
    {
        public int EB_NO { get; set; }
        public string Customer_Name {  get; set; }
        public long PhoneNumber {  get; set; }

        public static List<Customer> _CustomerList = new List<Customer>();

        public static Customer StoreCustomerAccount = null, _Customer = null;
        public void CreateCutomerAccount()
        {
            Console.WriteLine("Creating New Account !");
            _Customer = new Customer();

            Console.Write("Enter EB Number      :  ");
            _Customer.EB_NO = int.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name  :  ");
            _Customer.Customer_Name = Console.ReadLine();

            Console.Write("Enter Phone Number   :  ");
            _Customer.PhoneNumber = long.Parse(Console.ReadLine());

            StoreCustomerAccount = _Customer;

            _CustomerList.Add(_Customer);
            

        }

        public virtual void DisplayBill()
        {
            Console.WriteLine("Customer EB Number    :  " + StoreCustomerAccount.EB_NO);
            Console.WriteLine("Customer Name         :  " + StoreCustomerAccount.Customer_Name);
            Console.WriteLine("Customer Phone No     :  " + StoreCustomerAccount.PhoneNumber);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB_BillManagement
{
    public class Bill : Customer
    {
        public int EB_Num {  get; set; }
        public int Old_Reading {  get; set; }
        public int New_Reading { get; set;}
        public int Unit {  get; set;}
        public int Charge {  get; set;}

        public List<Bill> billList = null;

        public  Bill bill = null, StoreBillAccount = null;
        
    
        public List<Bill> InputBill()
        {
            billList = new List<Bill>();
            char x =' ';
            do
            {
                Console.Clear();
                bill = new Bill();

                Console.Write("Enter EB Number   :  ");
                int EB_Num = int.Parse(Console.ReadLine());
                Console.Clear();

                if (FindCustomerAccount(EB_Num) && FindEBAccount(EB_Num))
                {
                    Console.WriteLine("Account Is Present !");
                    
                    CalculateUnit(StoreBillAccount);

                    DisplayBill();

                }
                else
                {
                    Console.WriteLine("Account Is Not Present !");

                    CreateCutomerAccount();
                    Console.WriteLine("\nCustomer Account Created Successfully !\n");

                    bill.EB_Num = _Customer.EB_NO;

                    Console.Write("Enter Old Reading   :  ");
                    bill.Old_Reading = int.Parse(Console.ReadLine());

                    Console.Write("Enter New Reading   :  ");
                    bill.New_Reading = int.Parse(Console.ReadLine());

                    CalculateUnit(bill);

                    StoreBillAccount = bill;

                    Create(bill);

                    Console.ReadKey();
                    Console.Clear();

                    DisplayBill();

                }

                Console.Write("\n\tType [ Y ] To Continue [ N ] To Skip  ~  ");
                x = char.Parse(Console.ReadLine().ToUpper());

            }
            while (x!='N');

            return billList;
        }

        public void Create(Bill bill)
        {
            billList.Add(bill);
            Console.WriteLine("\nEB Account Created Successfully !!\n");

        }

        public void Read()
        {
            bool x = true;
            if(IsCustomerCount() && IsEBCount() )
            {
                foreach(var value1 in _CustomerList)
                {
                    foreach( var value2 in billList)
                    {
                        if(value1.EB_NO == value2.EB_Num)
                        {
                            string CustomerDetail="";
                            string BillDetail;
                            if (x)
                            {
                                
                                CustomerDetail = "EB Number :  " + value1.EB_NO + "  Customer Name :  " +
                                    value1.Customer_Name + "  Customer PhoneNo :  " + value1.PhoneNumber;

                                x = false;
                               
                            }
                            BillDetail = "Old Reading :  " + value2.Old_Reading + "  New Reading :  " + value2.New_Reading
                                   + "  Unit :  " + value2.Unit + "  Charges :  " + value2.Charge;

                            Console.WriteLine(CustomerDetail + BillDetail);
                        }
                    }
                }
            }
        }
        public bool FindCustomerAccount( int EBNumber)
        {
            foreach(var item in _CustomerList)
            {
                if(item.EB_NO == EBNumber)
                {
                    StoreCustomerAccount = item;
                    return true;
                }
                    
            }
            return false;
        }

        public bool FindEBAccount(int EBNumber)
        {
            foreach (var item in billList)
            {
                if (item.EB_Num == EBNumber)
                {
                    StoreBillAccount = item;
                    return true;
                }

            }
            return false;
        }

        public void CalculateUnit( Bill billAccount )
        {
            billAccount.Unit = billAccount.New_Reading - billAccount.Old_Reading ;
            billAccount.Charge = billAccount.Unit * 8;

        }

        public override void DisplayBill()
        {
            base.DisplayBill();

            Console.WriteLine("Customer Old Reading  :  " + StoreBillAccount.Old_Reading);
            Console.WriteLine("Customer New Reading  :  " + StoreBillAccount.New_Reading);
            Console.WriteLine("Consumed Unit         :  " + StoreBillAccount.Unit);
            Console.WriteLine("Total Charge          :  " + StoreBillAccount.Charge);
        }

        public bool IsCustomerCount()
        {
            if(_CustomerList != null && _CustomerList.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool IsEBCount()
        {
            if(billList != null && billList.Count > 0)
            {
                return true;
            }
            return false;
        }

    }
}

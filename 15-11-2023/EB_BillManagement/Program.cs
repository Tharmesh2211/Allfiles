using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB_BillManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Bill bill = new Bill();
            List<Bill> billList = bill.InputBill();
        }
    }
}

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Program
    {
        public delegate void DelDisplay();

        public delegate string DelGetName(string name);
        public static void Main(string[] args)
        {
            DelDisplay delDisplay = new DelDisplay(Display);
            delDisplay.Invoke();

            Program program = new Program();

            DelGetName delGetName = new DelGetName(program.GetName);

            string Name = delGetName.Invoke("Tharmesh");

            Console.WriteLine(Name);
        }

        public static void Display()
        {
            Console.WriteLine("Display Method Called !");
        }

        public string GetName(string Name)
        {
            return "Hello " + Name + " !";
        }


        //static void Main(string[] Args)
        //{
        //    string s = "ID int primary key,UserID int,total decimal,ID int primary key,Dname varchar(30),Ddesc varchar(30),discount_percent decimal,ID int primary key,Pname varchar(30),Pdesc varchar(30),SKU varchar(30),category varchar(30),price decimal,discount_id int,ID int primary key,sessionId int,product_Id int,quantity int,tID int primary key,product_Id int,ID int primary key,Order_Items_Id int,amount int,Pprovider varchar(30),Pstatus varchar(30),ID int primary key,UserID int,total decimal,payment_id int";
        //    string s1 = "";
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        s1 += s[i];

        //        if (s[i] == ',')
        //        {
        //            s1 = s1 + "@";
        //        }                   
        //    }
        //    Console.WriteLine(s1);

        //}
    }
}

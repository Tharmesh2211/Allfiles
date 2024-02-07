using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPassword
{
    internal class Program
    {

        static void User_Password(string[] UserName, string[] Password, string user, string pass)
        {
            bool check = true;
            for (int i = 0; i < UserName.Length; i++)
            {
                if ((user.Equals(UserName[i])) && (pass.Equals(Password[i])))
                {
                    check = false;
                    Console.WriteLine("Successfully Logged In");
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine("Login Failed");
            }
        }
        static void Main(string[] args)
        {
            string[] Username = { "tharmesh", "ganesh" };
            string[] Password = { "tharmesh@123", "ganesh@123" };

            Console.Write("Enter User Name  :  ");      string user = Console.ReadLine();

            Console.Write("Enter Password   :  ");      string pass = Console.ReadLine();

            User_Password(Username, Password,user,pass); 
        }
    }
    
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOINS
{
    public class LOGIN
    {
        public static Hashtable _hashTable = new Hashtable();

        public LOGIN()
        {
        }

        public void Add()
        {
            try
            {
                while (true)
                {
                    Console.Clear();
                    Console.Write("Enter User Name  -  ");
                    string Uname = Console.ReadLine();
                    Console.Write("Enter Password   -  ");
                    string Password = Console.ReadLine();
                    _hashTable.Add(Uname, Password);

                    Console.Write("ENTER [ Y ] TO CONTINUE [ N ] TO EXIT ~  ");

                    if (char.Parse(Console.ReadLine().ToUpper()) == 'N')
                    {
                        break;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Read()
        {
            Console.Clear();
            foreach (DictionaryEntry Dht in _hashTable)
            {
                Console.Write("USER NAME      :   " + Dht.Key);
                Console.WriteLine("    PASSWORD   :   " + Dht.Value);
            }
            Console.ReadKey();
        }

        public bool IsValid()
        {
            Console.Clear();

            Console.Write("Enter User Name  -  ");
            string Uname = Console.ReadLine();
            Console.Write("Enter Password   -  ");
            string Password = Console.ReadLine();


            var check = from DictionaryEntry dht in _hashTable
                        where dht.Key.Equals(Uname) && dht.Value.Equals(Password)
                        select dht;
            return check.Any();
        }

        public void Update()
        {
            Console.Clear();

            Console.Write("Enter User Name For Password Change  -  ");
            string Uname = Console.ReadLine();
            if (_hashTable.ContainsKey(Uname))
            {
                Console.Write("Enter Password   -  ");
                string Password = Console.ReadLine();

                _hashTable[Uname] = Password;
                Console.WriteLine("Password Changed Successfully !");
            }
            else
            {
                Console.WriteLine("No User Found !");
            }
            Console.ReadKey();
        }

        public void Delete()
        {
            Console.Write("Enter User Name For Password Change  -  ");
            string Uname = Console.ReadLine();
            if (_hashTable.ContainsKey(Uname))
            {
                _hashTable.Remove(Uname);
                Console.WriteLine("User deleted successfully!");
            }
            else
            {
                Console.WriteLine("No User Found !");
            }
            Console.ReadKey();
        }
    }
}

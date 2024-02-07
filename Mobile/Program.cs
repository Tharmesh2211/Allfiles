using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    internal class Program
    {
        public static void MobileWhile(string[] arr)
        {
            Console.WriteLine("Executing While Loop");

            int i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine("Mobile Model {0}  ", arr[i]);
                i++;
            }
        }

        public static void MobileDoWhile(string[] arr)
        {
            Console.WriteLine("Executing Do-While Loop");

            int i = 0;
            do
            {
                Console.WriteLine("Mobile Model {0}  ", arr[i]);
                i++;
            }
            while (i < arr.Length) ;
        }

        public static void MobileSwitch(string[] arr,int[] price)
        {
            Console.WriteLine("Executing Switch Loop");

            Console.Write("Enter Mobile Name :  ");
            string mobilename = Console.ReadLine().ToLower();
            int i;
            for(i = 0; i < arr.Length; i++)
            {
                if (mobilename.Equals(arr[i].ToLower()))
                {                    
                    break;
                }
                
            }
            switch (i)
            {
                case 0: Console.WriteLine("Iphone price is " + price[i]); break;         
                case 1: Console.WriteLine("SamSung price is "+ price[i]); break;
                case 2: Console.WriteLine("Vivo price is " + price[i]); break;
                case 3: Console.WriteLine("Oppo price is " + price[i]); break;
                case 4: Console.WriteLine("Redmi price is " + price[i]); break;
                case 5: Console.WriteLine("Motorla price is " + price[i]); break;
                case 6: Console.WriteLine("Infinix price is " + price[i]); break;
                default: Console.WriteLine("Invalid Mobile" + price[i]); break;
            }
        }

        static void Main(string[] args)
        {
            string[] mobile = { "Iphone", "Samsung", "Vivo", "Oppo", "Redmi", "Motorla", "Infinix" };
            int[] price = { 100000, 85000, 34000, 43000, 20000, 27800, 32400 };
            MobileWhile(mobile);
            MobileDoWhile(mobile);
            MobileSwitch(mobile,price);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BODMAS
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            // Integer data types
            int num1 = 10;
            int num2 = 5;
            int sum = num1 + num2;
            int diff = num1 - num2;
            int multi = num1 * num2;
            int div = num1 / num2;

            Console.WriteLine("Integer Data Types");
            Console.WriteLine("ADD : "+sum+" SUBSTRACT : "+diff+" MULTIPLY : "+multi+" DIVIDE : "+div);

            // Long data types
            
            long Lnum1 = 15400000000;
            long Lnum2 = 5000000000;
            long Lsum = Lnum1 + Lnum2;
            long Ldiff = Lnum1 - Lnum2;
            long Lmulti = Lnum1 * Lnum2;
            long Ldiv = Lnum1 / Lnum2;

            Console.WriteLine("Long Data Types");
            Console.WriteLine("ADD : " + Lsum + " SUBSTRACT : " + Ldiff + " MULTIPLY : " + Lmulti + " DIVIDE : " + Ldiv);


            // Floating-point data types
            float Fnum1 = 3.14f;
            float Fnum2 = 1.5f;
            float Fsum = Fnum1 + Fnum2;
            float Fdiff = Fnum1 - Fnum2;
            float Fmulti = Fnum1 * Fnum2;
            float Fdiv = Fnum1 / Fnum2;

            Console.WriteLine("Float Data Types");
            Console.WriteLine("ADD : " + Fsum + " SUBSTRACT : " + Fdiff + " MULTIPLY : " + Fmulti + " DIVIDE : " + Fdiv);


            // Double data types

            double Dnum1 = 3.14;
            double Dnum2 = 1.5;
            double Dsum = Dnum1 + Dnum2;
            double Ddiff = Dnum1 - Dnum2;
            double Dmulti = Dnum1 * Dnum2;
            double Ddiv = Dnum1 / Dnum2;

            Console.WriteLine("Double Data Types");
            Console.WriteLine("ADD : " + Dsum + " SUBSTRACT : " + Ddiff + " MULTIPLY : " + Dmulti + " DIVIDE : " + Ddiv);


            // Boolean data type
            bool isTrue = true;
            bool isFalse = false;

            

            // Character data type
            char charValue1 = 'A';
            char charValue2 = 'B';
            Console.WriteLine("ADD CHARACTER : "+charValue1 + charValue2);

            // String data type
            string Fname = "HI, ";
            string Lname = "THARMESH !!";
            string addname = Fname + Lname;

            Console.WriteLine("ADD BOTH STRING : "+addname);
        }
    }
}
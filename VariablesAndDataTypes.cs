using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkProgramKodluyoruz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 10; // 1 byte
            sbyte c = 12; // 1 byte

            short s = 13; // 2 byte
            ushort u = 14; // 2 byte

            Int16 i = 15; // 2 byte
            int j = 16; // 2 byte  
            Int32 j2 = 17; // 4 byte
            Int64 j3 = 18;  // 8 byte

            uint j4 = 19;   // 4 byte
            long j5 = 20;   // 8 byte
            ulong j6 = 21;  // 8 byte

            // float numbers
            
            float j7 = 22;  // 4 byte
            double j8 = 23; // 8 byte
            decimal j9 = 24;    // 16 byte

            char ch = 'a';  // 2 byte
            string str ="aliosman"; // unlimited

            bool b1 = true;
            bool b2 = false;

            DateTime dt= DateTime.Now;

            Console.WriteLine(dt);
          

            object obj = 'y';
            object obj1 = 'x';
            object obj2 = 4;
            object obj3 = 4.3;

            string str1 = string.Empty;
            str1 = "Ali Osman Demirkollu";
            string name = "Ali Osman";
            string surname = "Demirkollu";
            string fullname = name + " " + surname;

            int number1 = 13;
            int number2 = 17;
            int add = number1 + number2;


            bool bl = 10 > 2;

            string str20 = "20";
            int int20 = 20;

            string newValue = int20 + str20.ToString();

            Console.WriteLine(newValue); // output = 2020
            
            int newValue2 = int20 + Convert.ToInt32(str20);

            Console.WriteLine(newValue2); // output = 40

            string date = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(date);

            string date2 = DateTime.Now.ToString("dd.MMM.yy");
            Console.WriteLine(date2);

            string hour = DateTime.Now.ToString("HH.mm");
            Console.WriteLine(hour);

            Console.ReadLine();





        }
    }
}

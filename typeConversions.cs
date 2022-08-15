using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // implicit Conversion (bilinçsiz dönüşüm)
            Console.WriteLine("---------------- Implicit Conversion ----------------");
            byte a = 5;
            sbyte b = 30;
            short c = 25;

            int d = a + b + c;

            Console.WriteLine("d: " + d);

            long h = d;

            Console.WriteLine("h: " + h);

            float j = h;

            Console.WriteLine("j: " + j);

            string k = "aliosman";
            char f = 'k';
            object g = k + f + d;

            Console.WriteLine("g: " + g);

            // Explicit Conversion (bilinçli dönüşüm)

            Console.WriteLine("------------ Explicit Conversion -----------");

            int x = 4;
            byte y = (byte)x;

            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;

            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;

            Console.WriteLine("v: " + v);

            // ToString Method

            Console.WriteLine("------------- ToString Method ---------------");

            int xx = 6;
            string yy = xx.ToString();

            Console.WriteLine(yy);

            string zz = 12.5f.ToString();

            Console.WriteLine(zz);


            // System.Convert

            Console.WriteLine("------------ System.Convert -----------");

            string s1 = "10", s2 = "20";

            int number1, number2;

            int total;

            number1 = Convert.ToInt32(s1);

            number2 = Convert.ToInt32(s2);

            total = number1 + number2;

            Console.WriteLine("total: " + total);

            // Parse
            Console.WriteLine("-------------- Parse --------------");

            ParseMethod();

            Console.ReadLine();







        }

        public static void ParseMethod()
        {
            string metin = "10";
            string metin2 = "10.20";
            int number;
            double double1;

            number = int.Parse(metin);
            double1 = Double.Parse(metin2);

            Console.WriteLine("number: " + number);
            Console.WriteLine("double: " + double1);

        }


    }
}

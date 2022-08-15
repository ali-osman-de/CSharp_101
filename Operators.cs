using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            y = y + 2;


            //Assignment and Operational Assignment Operators

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 2;
            Console.WriteLine(y);
            x += 2;
            Console.WriteLine(x);


            // Logical Operators

            bool isSuccess = true;
            bool isFail = false;

            if (isSuccess && isFail) 
            {
                Console.WriteLine("Perfect!");
            }
            if (isSuccess || isFail) 
            {
                Console.WriteLine("Great!");
            }
            if (isSuccess && !isFail) 
            {
                Console.WriteLine("Fine!");
            }

            // Relational Operators

            int a = 10;
            int b = 16;
            bool result = a < b;

            Console.WriteLine(result);
            result = a > b;
            Console.WriteLine(result);
            result = a >= b;
            Console.WriteLine(result);
            result = a <= b;
            Console.WriteLine(result);
            result = a == b;
            Console.WriteLine(result);
            result = a != b;
            Console.WriteLine(result);

            // Arithmetic operators

            int number1 = 105;
            int number2 = 35;

            int result1 = number1 / number2;
            
            Console.WriteLine(result1);
            result1 = number1 + number2;
            Console.WriteLine(result1);
            result1 = number1 * number2;
            Console.WriteLine(result1);
            result1 = number1 - number2;
            Console.WriteLine(result1);
            result1 = number1++;
            Console.WriteLine(result1);


            int result2 = 20 % 3;
            Console.WriteLine(result2);


            Console.ReadLine();



        }
    }

    
}

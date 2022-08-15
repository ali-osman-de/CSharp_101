using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseIfTernary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("{0} girmiş olduğunuz sayi negatif bir değerdir.", number);
            }
            else if (number >= 0 && number <= 50)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("{0} girmiş olduğunuz sayi pozitif 0 ile 50 aralığında çift bir sayidir.", number);
                }
                else
                    Console.WriteLine("{0} girmiş olduğunuz sayi pozitif 0 ile 50 aralığında tek bir sayidir.", number);
             
            }
            else if (number > 50 && number <= 100)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("{0} girmiş olduğunuz sayi pozitif 51 ile 100 aralığında çift bir sayidir.", number);
                }
                else
                    Console.WriteLine("{0} girmiş olduğunuz sayi pozitif 51 ile 100 aralığında tek bir sayidir.", number);
             
            }
            else if (number > 100 && number <= 500)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("{0} girmiş olduğunuz sayi pozitif 101 ile 500 aralığında çift bir sayidir.", number);
                }
                else
                    Console.WriteLine("{0} girmiş olduğunuz sayi pozitif 101 ile 500 aralığında tek bir sayidir.", number);
              
            }
            else
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("{0} girmiş olduğunuz sayi pozitif 500'den büyük ve çift bir sayidir.", number);
                }
                else
                    Console.WriteLine("{0} girmiş olduğunuz sayi pozitif 500'den büyük tek bir sayidir.", number);
               
            }
            Console.ReadLine();   
        }
    }
}

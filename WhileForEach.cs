using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int sayac = 1;
            int result = 0;
            int avarage = 0;

            while (sayac <= number)
            {
                result = result + sayac;
                sayac++;
                


            }
            avarage = result / number;
            Console.WriteLine("1 ile {0} arasindaki sayilarin ortalamsı {1}",number,avarage);

            char character = 'a';

            while (character < 'z')
            {
                Console.WriteLine(character);
                character++;
            }

            string[] cars = { "BMW", "FORD", "NISSAN", "TOYOTA" };

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            
            Console.ReadLine();
        }
            
    }
}

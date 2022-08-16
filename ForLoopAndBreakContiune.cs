using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopAndBreakContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayacinizi ayarlamak için sayi giriniz: ");
            int sayac = int.Parse(Console.ReadLine());

            int oddtotal = 0;
            int eventotal = 0;

            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 0)
                {
                    eventotal = eventotal + i;
                    Console.WriteLine("{0} sayisi çifttir.", i);
                }
                else
                {   
                    oddtotal = oddtotal + i;
                    Console.WriteLine("{0} sayisi tektir.",i);
                }

            }
            Console.WriteLine("0 ile {0} arasindaki çift sayilarin toplami: {1}",sayac,eventotal);
            Console.WriteLine("0 ile {0} arasindaki tek sayilarin toplami: {1}",sayac,oddtotal);


            for (int j = 0; j < 10; j++)
            {
                if (j==4)
                {
                    continue;
                    
                }
                Console.WriteLine(j);
                if (j == 8)
                {
                    Console.WriteLine("Döngüyü 8 numarada duruyorum, Onaylıyor musunuz? Y/N: ");
                    string cond = Console.ReadLine();
                    if (cond == "Y")
                    {
                        Console.WriteLine("Döngüyü durdurdum.");
                        break;
                    }
                    
                }
            }


            Console.ReadLine();


        }
    }
}

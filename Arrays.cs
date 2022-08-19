using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dizi tanımlama

            string[] renkler = new string[5];
            
            string[] hayvanlar = { "kedi", "köpek", "kuş", "tilki" };

            int[] array;
            array = new int[6];

            // dizilere değer atama ve erişim

            renkler[0] = "mavi";
            Console.WriteLine(renkler[0]);
            Console.WriteLine(hayvanlar[0]);
            array[3] = 17;
            Console.WriteLine(array[3]);

            // döngülerle dizi kullanımı
            // klavyeden girilen n tane sayının ortalaması

            Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            int diziUzunluğu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunluğu];

            for (int i = 0; i < diziUzunluğu; i++)
            {
                Console.Write("Lütfen {0}. sayiyi giriniz: ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine
                    ());

            }

            int total = 0;

            foreach (var sayi in sayiDizisi)
            {
                total += sayi;
            }

            Console.WriteLine("Ortalama: {0}", total/diziUzunluğu);





            Console.ReadLine();



        }
    }
}

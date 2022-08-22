using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClassMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sort
            int[] sayiDizisi = { 23, 12, 85, 4, 72, 11, 17 };
            
            Console.WriteLine("****Sırasız Dizi****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);

            }

            Console.WriteLine("****Sıralı Dizi****");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            // clear

            Console.WriteLine("**** Array Clear ****");
            // sayiDizisi elemanlarını kullanarak 2.indexten itibaren iki elemanı sıfırladık

            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //reverse

            Console.WriteLine("**** Array Reverse ****");

            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //IndexOf

            Console.WriteLine("**** Array IndexOf ****");
            int number1 = Array.IndexOf(sayiDizisi, 23);

            Console.WriteLine(number1);

            //Resize
            Console.WriteLine("**** Array Resize ****");

            Array.Resize<int>(ref sayiDizisi, 9);

            sayiDizisi[8] = 29;

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }



            Console.ReadLine();
        }
    }
}

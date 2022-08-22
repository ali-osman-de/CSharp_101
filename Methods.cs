using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geri_donustipi metot_adi(parametreListesi/arguman)
            //{
            ////komutlar;
            //}

            int a = 2;
            int b = 3;
            
            Console.WriteLine(a + b);


            int result = Topla(a, b);
            
            Console.WriteLine(result);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdır(Convert.ToString(result));

            int sonuc2 = ornek.ArttırVeTopla(a, b);

            Console.WriteLine(sonuc2);

            Console.ReadLine();
        }

        static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }
    }


    class Metotlar
    {
        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }


        public int ArttırVeTopla(int deger1, int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }





}

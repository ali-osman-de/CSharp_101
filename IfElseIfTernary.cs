
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
            int time = DateTime.Now.Hour;


            if (time >= 6 && time < 12)
            {
                Console.WriteLine("Günaydın!");
            }
            else if (time >= 12 && time <= 18)
            {
                Console.WriteLine("İyi Günler!");
            }
            else
            {
                Console.WriteLine("İyi Geceler!");
            }


            string sonuc = time <= 18 ? "İyi günler!" : "İyi geceler!";

            sonuc = time > 6 && time <= 11 ? "Günaydın" : time < 18 ? "İyi Günler!" : "İyi geceler";

            Console.WriteLine(sonuc);
            
            Console.ReadLine();
        }
    }
}

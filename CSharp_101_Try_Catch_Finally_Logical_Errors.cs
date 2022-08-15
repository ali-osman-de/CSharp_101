using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinallyveMantıksalHatalar
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            try
            {
                Console.WriteLine("Enter a number: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number you entered {0}", sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }
            finally 
            {
                Console.WriteLine("Process completed.");
            }

            // Special Exceptions

            try 
            {
                int num = int.Parse(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("You entered an empty value!");
                Console.WriteLine(ex);
            }

            try
            {
                int a = int.Parse("test");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("The data type is not suitable!");
                Console.WriteLine(ex);
            }

            try
            {
                int b = int.Parse("-100000000000");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("You entered a value that is too small or too large!");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Transaction Completed Successfully.");
            }


            Console.ReadLine();
        }
    }
}

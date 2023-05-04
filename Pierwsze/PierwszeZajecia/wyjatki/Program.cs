using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyjatki
{
    internal class Program 
    {
        static void Main(string[] args)
        {

            try { 
            var lapanieWyjatkow = new LapanieWyjatkow();

            // Przykład z NullReferenceException
            int[] liczby1 = null;
            lapanieWyjatkow.Podziel(liczby1);

            // Przykład z IndexOutOfRangeException
            int[] liczby2 = { 1, 2, 3 };
            lapanieWyjatkow.Podziel(liczby2);

            // Przykład z DivideByZeroException
            int[] liczby3 = { 1, 2, 3, 4, 0 };
            lapanieWyjatkow.Podziel(liczby3);

            // Przykład z OverflowException
            int[] liczby4 = { Int32.MaxValue, 2, 3, 4, 1 };
            lapanieWyjatkow.Podziel(liczby4);
            
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message );
                Console.WriteLine("Source: " + ex.Source );
                Console.WriteLine("StackTrace: " + ex.StackTrace.ToString() );
                Console.WriteLine("TargetSite: " + ex.TargetSite.ToString() );
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
    }
}

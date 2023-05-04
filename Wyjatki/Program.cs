using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] t0 = null;
            int[] t1 = { 1, 2, 3 };
            int[] t2 = { 1, 2, 3, 4, 0 };
            int[] t3 = { 30, 100, 100, 100, 100 };
            int[] t4 = { 30, int.MaxValue, 2 ,3 ,4 };
            LapanieWyjatkow test = new LapanieWyjatkow();

/*            test.Podziel(t0);
            test.Podziel(t1);
            test.Podziel(t2);
            test.Podziel(t3);
            test.Podziel(t4);*/
           try
            {
               test.Podziel(t0);
                test.Podziel(t1);
                test.Podziel(t2);
                test.Podziel(t3);
                test.Podziel(t4);
            }
            catch (Exception e)
            {
                Console.WriteLine("Domyślny opis:\n{0}\n", e.ToString());
                Console.WriteLine("Message:\n{0}\n", e.Message);
                Console.WriteLine("StackTrace:\n{0}\n", e.StackTrace);
                Console.WriteLine("Source:\n{0}\n", e.Source);
                Console.WriteLine("TargetSite:\n{0}\n", e.TargetSite);
            }
            // Console.WriteLine("Wynik: {0}", wynik);
            int iloscKrokow = 100000;
            int iloscWyrzucenWyjatku = 0;
            TestMojegoWyjatku t = new TestMojegoWyjatku();

            for (int i = 0; i < iloscKrokow; i++)
            {
                try
                {
                    t.Test();
                }
                catch (MojException)
                {
                    iloscWyrzucenWyjatku++;
                }
            }
            Console.WriteLine(
                4.0 * iloscWyrzucenWyjatku / iloscKrokow);
        }
    }
}

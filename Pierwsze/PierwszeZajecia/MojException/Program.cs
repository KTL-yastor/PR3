using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojException
{
    internal class Program
    {
        const int IloscProbek = 10000;
        static void Main(string[] args)
        {
            int iloscPrzechwycen = 0;
            TestMojegoWyjatku test = new TestMojegoWyjatku();

            for (int i = 0; i < IloscProbek; i++)
            {
                try
                {
                    test.Test();
                }
                catch (MojException ex)
                {
                    iloscPrzechwycen++;
                    Console.WriteLine(ex.Message);
                   // Console.WriteLine("Wyjatek MojException zostal zgloszony");
                }
            }
            Console.WriteLine(4.0* iloscPrzechwycen / IloscProbek);

        }
    }
}

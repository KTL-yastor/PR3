using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCw
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double[] tab = new double[5];
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Podaj {0} liczbę", i + 1);
                tab[i] = double.Parse(Console.ReadLine());
            }
            ISrednia srednia = new SredniaArytmetyczna();
            Console.WriteLine("Średnia arytmetyczna wynosi: {0}", srednia.ObliczSrednia(tab));
            srednia = new SredniaHarmoniczna();
            Console.WriteLine("Średnia harmoniczna wynosi: {0}", srednia.ObliczSrednia(tab));
            srednia = new SredniaGeometryczna();
            Console.WriteLine("Średnia geometryczna wynosi: {0}", srednia.ObliczSrednia(tab));
            srednia = new SredniaKwadratowa();
            Console.WriteLine("Średnia kwadratowa wynosi: {0}", srednia.ObliczSrednia(tab));
            Console.ReadKey();
                      
        }
    }
}

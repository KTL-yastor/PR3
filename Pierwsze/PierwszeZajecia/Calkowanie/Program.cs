using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calkowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a, b, c: ");
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());
            FunkcjaKwadratowa f = new FunkcjaKwadratowa(a, b, c);
            Console.WriteLine("Podaj początek przedziału: ");
            double poczatek = int.Parse(Console.ReadLine());
            Console.WriteLine("Wartosc funkcji w punkcie {0} wynosi {1}", poczatek, f.Wartosc(poczatek));
            Console.WriteLine("Podaj koniec przedziału: ");
            double koniec = int.Parse(Console.ReadLine());
            Console.WriteLine("Wartosc funkcji w punkcie {0} wynosi {1}", koniec, f.Wartosc(koniec));
            Console.WriteLine("Calka oznaczona funkcji w przedziale [{0}, {1}] wynosi {2}", poczatek, koniec, f.CalkaOznaczona(poczatek, koniec));

        }
    }
}

using System;

namespace WyjatkiZadanie5
{
    public class SzukaniePierwiastka
    {
        public static void Szukaj(FunkcjaDelegat f,
            double poczatek, double koniec, double delta)
        {
            try
            {
                Testuj(f, poczatek, (poczatek + koniec) / 2, delta);
                Testuj(f, (poczatek + koniec) / 2, koniec, delta);
            }
            catch (PrzedzialException p)
            {
                Szukaj(p.Funkcja, p.Poczatek, p.Koniec, delta);
            }
        }
        static void Testuj(FunkcjaDelegat f,
            double poczatek, double koniec, double delta)
        {
            if (f(poczatek) <= 0 && f(koniec) >= 0 
                || f(poczatek) >= 0 && f(koniec) <= 0)
            { 
                if (Math.Abs(koniec-poczatek) < Math.Abs(delta))
                {
                    Console.WriteLine("Znaleziono pierwiastek {0}",
                        (poczatek + koniec) / 2);
                }
                else
                {
                    throw new PrzedzialException(f, poczatek, koniec, delta);
                }
            }

        }

    }
}

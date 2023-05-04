using System;

namespace WyjatkiZadanie5
{
    //delegate double FunkcjaDelegat(double x);
    class PrzedzialException : Exception
    {
       // public readonly Func<double, double> Funkcja;
        public  FunkcjaDelegat Funkcja;
        public readonly double Poczatek;
        public readonly double Koniec;
        // public PrzedzialException(Func<double, double> f, double poczatek, double koniec, double delta)
        public PrzedzialException(FunkcjaDelegat f,
            double poczatek, double koniec, double delta)
        {
            Funkcja = f;
            Poczatek = poczatek;
            Koniec = koniec;
        }
    }
}

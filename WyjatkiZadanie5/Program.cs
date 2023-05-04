using System;

namespace WyjatkiZadanie5
{
    public delegate double FunkcjaDelegat(double x);
    class Program
    {
        static void Main(string[] args)
        {

            /*Func<double, double> f = 
                x => x * x * x - 2 * x * x - x + 2;*/
            FunkcjaDelegat f =
                                x => x * x * x - 2 * x * x - x + 2;
            SzukaniePierwiastka.Szukaj(f, -10, 10, .0001);
            SzukaniePierwiastka.Szukaj(x => x - 1, -20, 10, .000001);
        }
    }
}

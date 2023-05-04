using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calkowanie
{
    internal class FunkcjaKwadratowa
    {
        private double a;
        private double b;
        private double c;

        public FunkcjaKwadratowa(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Wartosc(double x)
        {
            return (a * x + b) * x + c;
        }

        public double CalkaOznaczona(double x1, double x2)
        {
            return  Math.Round((a / 3 * x1 * x1 * x1 + b / 2 * x1 * x1 + c * x1) - (a / 3 * x2 * x2 * x2 + b / 2 * x2 * x2 + c * x2), 2);
        }


    }
}

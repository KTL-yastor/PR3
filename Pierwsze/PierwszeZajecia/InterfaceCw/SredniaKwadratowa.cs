using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCw
{
    internal class SredniaKwadratowa : ISrednia
    {
        public double ObliczSrednia(double[] tab)
        {
            double suma = 0;
            foreach (var v in tab)
            {
                suma += Math.Pow(v, 2);
            }
            return Math.Sqrt(suma / tab.Length);
            throw new NotImplementedException();
        }
    }
}

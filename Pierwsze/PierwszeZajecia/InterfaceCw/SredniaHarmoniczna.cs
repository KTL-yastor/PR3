using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCw
{
    internal class SredniaHarmoniczna : ISrednia
    {
        public double ObliczSrednia(double[] tab)
        {
            double suma = 0;
            foreach (var v in tab)
            {
                suma += 1 / v;
            }
            return tab.Length / suma;
            throw new NotImplementedException();
        }
    }
    
}


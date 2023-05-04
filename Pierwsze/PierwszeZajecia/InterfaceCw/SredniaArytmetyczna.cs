using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCw
{
    internal class SredniaArytmetyczna : ISrednia
    {
        public double ObliczSrednia(double[] tab)
        {
            double suma = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                suma += tab[i];
            }
            return suma / tab.Length;
            throw new NotImplementedException();
        }
    }
}

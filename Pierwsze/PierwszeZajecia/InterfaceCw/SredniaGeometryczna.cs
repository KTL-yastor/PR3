using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCw
{
    internal class SredniaGeometryczna : ISrednia
    {
        public double ObliczSrednia(double[] tab)
        {
            double iloczyn = 1;
            for (int i = 0; i < tab.Length; i++)
            {
                iloczyn *= tab[i];
            }
            return Math.Pow(iloczyn, 1.0 / tab.Length);
            throw new NotImplementedException();
        }
    }
}

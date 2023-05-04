using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojazd
{
    internal class Rower : Pojazd
    {
        public Rower()
        {
            kola = 2;
            miejsca = 1;

        }

        public Rower(double cena, double waga, int miejsca = 1, int kola = 2)
        { 
            UstawCenę(cena);
            UstawWagę(waga);
            UstawIloscMiejsc(miejsca);
            UstawIloscKol(kola);
        }

        public override bool CzyMaDach()
        {
            return false;
        }

        public override bool CzyToWieloslad()
        {
            return kola > 2;
        }

        public override bool CzyUtonie()
        {
            return true; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojazd
{
    internal class Rower : Pojazd
        
    {
        //konstruktor
        public Rower(double waga, double cena, int miejsca = 1, int kola = 2) 
        {
            UstawIloscMiejsc(miejsca);
            UstawIloscKol(kola);
            UstawCene(cena);
            UstawWage(waga);

        }

        public override bool CzyMaDach()
        {
            return false;
        }

        public override bool CzyToWieloslad()
        {
            return false;
        }

        public override bool CzyUtonie()
        {
            return true;
        }
    }
}

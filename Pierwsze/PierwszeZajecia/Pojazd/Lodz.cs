using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojazd
{
    internal class Lodz : Pojazd
    {


        public Lodz(double waga, double cena, int miejsca = 2, int kola = 0)
            :base(waga, cena, miejsca, kola)
        {

        }
        public override bool CzyMaDach()
        {
            return cena >= 20000;
        }
        
        public override bool CzyToWieloslad()
        {
            return false;
        }

        public override bool CzyUtonie()
        {
            return false;
        }
    }
}

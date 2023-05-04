using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojazd
{
    class Samochod : Pojazd
    {
        public Samochod(double waga, double cena, int miejsca = 5, int kola = 4) : base(waga, cena, miejsca, kola)
        {
        }
        public Samochod() { }
        public override bool CzyMaDach()
        {
			return true;
		}

        public override bool CzyToWieloslad()
        {
            return true;
		}

        public override bool CzyUtonie()
        {
			return false;
		}
    }
}

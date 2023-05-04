using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojazd
{
    internal class Samochod : Pojazd
    {
        private bool czyMaDach;
        // zwykly konstruktor 
        public Samochod()
        {
            miejsca = 4;
            czyMaDach = true;
            kola = 4;
        }

        //konstruktor gdy podane sa arg

        public Samochod(double waga, double cena, int kola = 4, int miejsca = 4, bool czyMaDach = true) : base(miejsca, kola, waga, cena)
        {

            this.czyMaDach = czyMaDach;

        }

        //metody

        public override bool CzyMaDach()
        {
            return czyMaDach;
        }

        public override bool CzyToWieloslad()
        {
            return true;
        }

        public override bool CzyUtonie()
        {
            return true;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojazd
{
    internal abstract class Pojazd : IComparable<Pojazd>
    {
        //protected czyli widoczne tylko dla klas pochodnych 
        protected int miejsca;
        protected int kola;
        protected double waga, cena;
        //konstruktor w tej klasie pozwoli uzywac base w klasach pochodnych

        public Pojazd() { }

        public Pojazd(int miejsca, int kola, double waga, double cena)
        {
            this.miejsca = miejsca;
            this.kola = kola;
            this.waga = waga;
            this.cena = cena;
        }


        //UstawIloscMiejsc(-), UstawiIloscKol(-), UstawCenę(-), UstawWagę(-) 
        public void UstawIloscMiejsc(int miejsca)
        { 
            this.miejsca = miejsca;
        }

        public void UstawIloscKol(int kola)
        { 
            this.kola = kola;
        }

        public void UstawCenę(double cena)
        { 
            this.cena = cena;
        }

        public void UstawWagę(double waga)
        { 
            this.waga = waga;
        }

        public abstract bool CzyToWieloslad();
        public abstract bool CzyMaDach();
        public abstract bool CzyUtonie();

        public int CompareTo(Pojazd other)
        {
            if (other.cena == this.cena) return 0;
            if (other.cena > this.cena) return -1;
            if (other.cena < this.cena) return 1;
            return 0;
        }

        public override string ToString()
        {
            string nazwaKlasy = base.ToString().Split('.')[1];
            return nazwaKlasy + "o cenie: " + cena.ToString();
        }
    }
}

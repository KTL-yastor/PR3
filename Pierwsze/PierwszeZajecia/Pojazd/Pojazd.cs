using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojazd
{
    abstract class Pojazd : IComparable<Pojazd>
    {
        /*Do projektu dodaj klasę abstrakcyjną Pojazd z polami miejsca, kola, cena, waga, zaimplementowanymi metodami UstawIloscMiejsc(-), UstawiIloscKol(-), UstawCenę(-), UstawWagę(-) oraz abstrakcyjnymi metodami CzyToWieloslad(), CzyMaDach(), CzyUtonie().*/

        protected int miejsca;
        protected int kola;
        protected double cena;
        protected double waga;

        public Pojazd() { } // potrzebny bo 
        public Pojazd(double waga, double cena, int miejsca, int kola)
        {
            UstawIloscMiejsc(miejsca);
            UstawIloscKol(kola);
            UstawCene(cena);
            UstawWage(waga);

        }

        public void UstawIloscMiejsc(int miejsca)
        {
            this.miejsca = miejsca;
        }

        public void UstawIloscKol(int kola)
        {
            this.kola = kola;
        }

        public void UstawCene(double cena)
        {
            this.cena = cena;
        }

        public void UstawWage(double waga)
        {
            this.waga = waga;
        }

        public abstract bool CzyToWieloslad();
        public abstract bool CzyMaDach();
        public abstract bool CzyUtonie();

        public int CompareTo(Pojazd other)
        {
            if (other.cena > cena)
            {
                return -1;
            }
            if (other.cena < cena)
            {
                return 1;
            }
            if (other.waga < waga)
            {
                return 1;
            }
            if (other.waga > waga)
            {
                return -1;
            }
            return 0;
        }

        public override string ToString()
        {

            //return "Pojazd: " + "miejsca: " + miejsca + " kola: " + kola + " cena: " + cena + " waga: " + waga;
            return GetType().Name + " " + "miejsca: " + miejsca.ToString() + " kola: " + kola.ToString() + " cena: " + cena.ToString() + " waga: " + waga.ToString();
        }

    }
}

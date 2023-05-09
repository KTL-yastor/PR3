using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class person
    {
        public string Imie { set; get; } 
        public string nazwisko;

        public person(string imie, string nazwisko)
        {
            this.Imie = imie;
            this.nazwisko = nazwisko;
        }
        public person() {
            Imie = "jan";
            nazwisko = "nowak";
        }
    }
}

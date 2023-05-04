using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabliczkaMnozenia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabliczka tablica = new Tabliczka (10,10);
            tablica.WyswietlTabliczke();
        }
    }
}

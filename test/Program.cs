using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person osoba = new person("df","adamowicz");
            Console.WriteLine(osoba.nazwisko);
            osoba.Imie = "jan";
            Console.WriteLine(osoba.Imie);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przeciazenia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zespolona a = new Zespolona(1, 2);
            // można też: Zespolona b = a + new Zespolona(1, 1);
            //test
            Zespolona b = a + 3;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.Write(b);
            Console.Write(b++);
            Console.WriteLine(b);
            b--;
            Console.Write(b);
            Console.Write(++b);
            Console.WriteLine(b);
            Console.WriteLine(b == new Zespolona(5, 2));
            Console.WriteLine(b == new Zespolona(5, 1));
        }
    }
}

/*
o tablicach 
int[] tablica2 = new int[5] { 1, 2, 3, 4, 5 };
var tablica3 = new[] { 1, 2, 3, 4, 5 };
int[] tablica4 = { 1, 2, 3, 4, 5 };
var studenci = new[] {
new { Imie = "Jan",
Nazwisko = "Kowalski" },
new { Imie = "Anna",
Nazwisko = "Nowak" }
};
var rozne = new object[] {
new { Imie = "Jan", wiek = 23,
Nazwisko = "Kowalski" },
new { Imie = "Anna",
Nazwisko = "Nowak" },
new { Przedmiot = "Algebra",
Godzin = "60" },
"jakiś tekst", 5, 4.01
};
int[,] tablica2wym = new int[2, 3] {{ 1, 2, 3 },{ 4, 5, 6 }};
int[] tab = { 1, 2, 3, 4 };
int[] kopia1 = new int[tab.Length];
tab.CopyTo(kopia1, 0);
int[] kopia2 = new int[tab.Length];
Array.Copy(tab, kopia2, tab.Length);
int[] kopia3 = (int[])tab.Clone();
 
*/

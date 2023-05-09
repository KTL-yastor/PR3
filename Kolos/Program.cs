using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            System.Console.ReadKey();
            string napis = System.Console.ReadLine();
            System.Console.WriteLine(napis);
            //przeczytanie jednego znaku
            char znak = (char)System.Console.Read();

            //wypisanie arg z konsoli
            System.Console.WriteLine(args[0]);

            //konwersja napis na int 
            int liczba;
            try {
                liczba = int.Parse(napis);
                Console.WriteLine(liczba);
            }
            catch (FormatException)
            {
                Console.WriteLine("Zly format liczby");
            }
            

        }
    }
}

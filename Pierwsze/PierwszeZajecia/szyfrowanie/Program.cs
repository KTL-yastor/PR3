using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szyfrowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
Napisz program, który wczyta jeden wiersz tekstu i wydrukuje go w wersji zaszyfrowanej. 
            Szyfrowanie pojedynczej litery polega na odpowiedniej zmianie kolejności czterech najmniej znaczących bitów.
            Miejscami powinny zostać zamienione trzeci bit z czwartym oraz pierwszy z drugim. Program ma wczytywać ze strumienia 
            wejściowego znaki tak długo aż napotka znak nowej linii. Wówczas ma wypisać zakodowany ciąg znaków. 
             
             */
            Console.WriteLine("Podaj tekst do zaszyfrowania: ");
            string tekst = Console.ReadLine();
            Console.WriteLine("Zaszyfrowany tekst: ");
            string zaszyfrowany = "";
            foreach (char c in tekst)
            {
                int kodZnaku = c & -15;
                kodZnaku |= (c & 1) << 1;
                kodZnaku |= (c & 2) >> 1;
                kodZnaku |= (c & 4) << 1;
                kodZnaku |= (c & 8) >> 1;
                zaszyfrowany += (char)kodZnaku;
            }
            Console.WriteLine(zaszyfrowany);
            Console.WriteLine();
            
        }
    }
}

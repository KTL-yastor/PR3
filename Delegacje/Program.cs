using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegacje
{
    delegate int Dodawanie(int a, int b);
    delegate void ZapisywanieWyswietlanie(string wiadomosc);
    internal class Program
    {

        static int dodaj1(int a, int b)
        {
            Console.WriteLine("Zwracam raz");
            return a + b;
        }


        static void Main(string[] args)
        {

            Delegacje przyklad = new Delegacje();

            Console.WriteLine("Przyklad uzycia delegacji - wywolanie metody Akcja1 z klasy Klasa1 po sobie");

            przyklad.UzycieDelegacji();

            Console.WriteLine("Kliknij \"K\". aby odpalic zmiane delegacji");

            if (Console.ReadKey().Key == ConsoleKey.K)
            { 
                przyklad.DodanieDelegacjiLambda();
                przyklad.UzycieDelegacji();
            }

            Console.WriteLine("teraz dodawanie liczb za pomoca delegacji test ");

            Dodawanie dodawanieliczb = dodaj1;

            dodawanieliczb += dodaj1;

            Console.WriteLine(dodawanieliczb(2, 3));
            Console.WriteLine(dodawanieliczb(2, 3));


            Console.WriteLine("teraz praktyczny przyklad delegacji , kolejkowanie funkcji po sobie");

            ZapisywanieWyswietlanie delegat = null;
            delegat = WyswietlWiadomosc;
            delegat += ZapiszWiadomosc;

            delegat("Wiadomosc testowa");



        }


        static void WyswietlWiadomosc(string wiadomosc) 
        {
            Console.WriteLine("Wiadomosc wyswietlona: " + wiadomosc);

        }

        static void ZapiszWiadomosc(string wiadomosc) 
        {
            Console.WriteLine("Wiadomosc zapisana do pliku: "+ wiadomosc);
        }
    }
}

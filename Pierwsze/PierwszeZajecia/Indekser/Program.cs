using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indekser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bool32 bits = new Bool32(0);

            // Ustawiamy bit o indeksie 3 na true
            bits[3] = true;

            // Wyświetlamy wartość bitu o indeksie 3
            Console.WriteLine(bits[3]); // powinno wyświetlić: True

            // Ustawiamy bit o indeksie 5 na false
            bits[5] = false;

            // Wyświetlamy wartość bitu o indeksie 5
            Console.WriteLine(bits[5]); // powinno wyświetlić: False

            // Próba ustawienia bitu o nieprawidłowym indeksie powinna zwrócić wyjątek ArgumentOutOfRangeException
            try
            {
                bits[-1] = true;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message); // powinno wyświetlić: indeks
            }
        }



struct Bool32
        {
            private int liczba;

            public Bool32(int init)
            {
                liczba = init;
            }

            //  Ustawia lub zwraca wartość bitu o podanym indeksie
            public bool this[int i]
            {
                // get - zwraca wartość bitu o podanym indeksie
               

                get
                {
                    if (i < 0 || i >= 32)
                        throw new ArgumentOutOfRangeException("indeks");

                    return (liczba & (1 << i)) != 0; //zwraca true jeśli bit jest ustawiony na 1
                }
                set
                {
                    if (i < 0 || i >= 32)
                        throw new ArgumentOutOfRangeException("indeks");

                    if (value)
                        liczba |= (1 << i); //inaczej liczba = liczba | (1 << i)
                    else
                        liczba &= ~(1 << i); // inaczej liczba = liczba & ~(1 << i)
                }
            }
        }

    }
}


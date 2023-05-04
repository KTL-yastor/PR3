using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabliczkaMnozenia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pobranie liczby n z argumentu
            int n = int.Parse(args[0]);
            //wyświetlenie tabliczki mnożenia
            for (int i = 1; i <= n; i++)
            {
                //kazda linia w innym kolorze
                Console.ForegroundColor = (ConsoleColor)(i % 15);
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("{0,4}", i * j); // zapis {0, 4} oznacza że wypisz 0 argument w polu o szerokości 4
                }
                Console.WriteLine();
            }
        }
    }
}

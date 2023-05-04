using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojazd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pojazd[] pojazdy =
            {
                new Rower (10, 1800),
                new Rower (10, 2000, 1),
                new Samochod (70, 33000),
                new Lodz (1230, 20000, 1),
                new Lodz (1111, 11111, 1)
            };

            Array.Sort(pojazdy);
            foreach (var pojazd in pojazdy)
            {
                Console.WriteLine(pojazd);
            }
        }
    }
}

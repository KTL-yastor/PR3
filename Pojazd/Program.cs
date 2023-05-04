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
            Pojazd[] pojazdy = {
                new Rower(100, 10), new Rower(200, 20), new Rower(300, 30), new Rower(400, 40), new Samochod(3000,25000), new Samochod(4000,35000), new Samochod(5000,45000), new Samochod(6000,55000)
            };

            Array.Sort(pojazdy);

            foreach (Pojazd p in pojazdy)
            {
                Console.WriteLine(p);
            }
        }
    }
}

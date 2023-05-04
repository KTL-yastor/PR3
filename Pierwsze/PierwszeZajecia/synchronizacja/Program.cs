using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace synchronizacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pisarz pisarz = new Pisarz();

            Thread watek1 = new Thread(new ParameterizedThreadStart(pisarz.Wypisz));
            watek1.Name = "Wątek 1";
            watek1.Priority = ThreadPriority.Lowest;

            Thread watek2 = new Thread(new ParameterizedThreadStart(pisarz.Wypisz));
            watek2.Name = "Wątek 2";
            watek2.Priority = ThreadPriority.Highest;

            watek1.Start(watek1.Name);
            watek2.Start(watek2.Name);

            watek1.Join();
            watek2.Join();

            Console.WriteLine("Koniec programu.");
        }
    }
}

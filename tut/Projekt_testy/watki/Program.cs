using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace watki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nowy wątek
            //nowy obiekt licnzik
            licznik licznik1 = new licznik(10);
            //Console.WriteLine("{0} , {1}", licznik1.step, licznik1.start);
            //licznik1.count();
            //Console.WriteLine("After method count {0}, {1}", licznik1.step, licznik1.start);
            //licznik1.countTo100();
            //Console.WriteLine("After method countTo100 {0}, {1}", licznik1.step, licznik1.start);
            Thread watek = new Thread(new ParameterizedThreadStart(licznik1.countTo100w));
            watek.Start(true);
            watek.Join();
            Thread watek2 = new Thread( () => licznik1.countTo100w(true));

        }



    }
}

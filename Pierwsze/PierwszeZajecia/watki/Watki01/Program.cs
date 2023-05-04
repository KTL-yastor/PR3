using System;
using System.Threading;
namespace WatkiPrzyklad1
{
    class Program
    {
        static void MetodaWatku()
        {
            for (int i = 1; i < 8; i++)
            {
                Console.WriteLine("Wątek Potomny ({0})", i);
                Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(MetodaWatku));
            t.Start();
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Wątek Przodka ({0})", i);
                Thread.Sleep(100);
            }
            Console.WriteLine("Wątek Przodka: oczekiwanie na zakończenie"
            + " wątku potomka.");
            t.Join();
            Console.WriteLine("Wątek Przodka: wątek potomka się zakończył.");
        }
    }
}

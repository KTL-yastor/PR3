using System;
using System.Threading;
namespace WatkiPrzyklad6
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(MetodaWatku), "argument");
            ThreadPool.QueueUserWorkItem(new WaitCallback(MetodaWatku));
            // Thread.Sleep(500);
            Thread.Sleep(100);
            Console.WriteLine("Zakończenie wątku głównego");
        }
        static void MetodaWatku(Object o)
        {
            Console.WriteLine("Wywołanie wątku (z argumentem \"{0}\")", o ?? "<null>");
            Thread.Sleep(200);
            Console.WriteLine("Wywołanie wątku (2)");
        }
    }
}
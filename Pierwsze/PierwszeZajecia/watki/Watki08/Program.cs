using System;
using System.Threading;
namespace WatkiPrzyklad7
{
    class Program
    {
        static void Main(string[] args)
        {
            //int watki, komunikacja;
            //ThreadPool.GetMaxThreads(out watki, out komunikacja);
            //ThreadPool.SetMaxThreads(1, komunikacja);
            for (int i = 11; i < 15; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(MetodaWatku), i);
            }
            Thread.Sleep(30);
            for (int i = 501; i < 505; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(MetodaWatku), i);
            }
            Console.WriteLine("Zakończenie dodawania do puli");
            Thread.Sleep(2100);
            Console.WriteLine("Zakończenie wątku głównego");
        }
        static void MetodaWatku(Object o)
        {
            Console.WriteLine("Wywołanie wątku z argumentem \"{0}\"", o);
            Thread.Sleep((int)o);
            Console.WriteLine("Zakończenie wątku z argumentem \"{0}\"", o);
        }
    }
}
using System;
using System.Threading;
namespace WatkiPrzyklad8
{
    class Program
    {
        static void MetodaWatku(Object o)
        {
            int watki, komunikacja;
            ThreadPool.GetAvailableThreads(out watki, out komunikacja);
            Console.WriteLine("Wywołanie wątku z argumentem \"{0}\"" +
                         " Available: {1}, {2}", o, watki, komunikacja);
            Thread.Sleep((int)o);
            Console.WriteLine("Zakończenie wątku z argumentem \"{0}\"", o);
        }
        static void Main(string[] args)
        {
            int watki, komunikacja;
            ThreadPool.GetMaxThreads(out watki, out komunikacja);
            Console.WriteLine("Max: {0}, {1}", watki, komunikacja);
            ThreadPool.GetMinThreads(out watki, out komunikacja);
            Console.WriteLine("Min: {0}, {1}", watki, komunikacja);
            ThreadPool.GetAvailableThreads(out watki, out komunikacja);
            Console.WriteLine("Available: {0}, {1}", watki, komunikacja);
            for (int i = 601; i < 605; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(MetodaWatku), i);
            }
            ThreadPool.GetAvailableThreads(out watki, out komunikacja);
            Console.WriteLine("Available: {0}, {1}", watki, komunikacja);
            Thread.Sleep(600);
            ThreadPool.GetAvailableThreads(out watki, out komunikacja);
            Console.WriteLine("Available: {0}, {1}", watki, komunikacja);
            ThreadPool.GetMinThreads(out watki, out komunikacja);
            if (ThreadPool.SetMinThreads(3, komunikacja))
            {
                Console.WriteLine("Ustawiono minimalną liczbę wątków");
            }
            else
            {
                Console.WriteLine("Nie ustawiono minimalnej liczby wątków");
            }
            ThreadPool.GetMinThreads(out watki, out komunikacja);
            Console.WriteLine("Min: {0}, {1}", watki, komunikacja);
            Thread.Sleep(2100);
            Console.WriteLine("Zakończenie wątku głównego");
        }
    }
}
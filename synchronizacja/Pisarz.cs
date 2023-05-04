using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace synchronizacja
{
    internal class Pisarz
    {
        private object _lock = new object();

        public void Wypisz(object nazwa)
        {
            lock (_lock)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0} - {1}: {2}", nazwa, i, DateTime.Now);
                    Thread.Sleep(10);
                }
            }
        }
    }
}

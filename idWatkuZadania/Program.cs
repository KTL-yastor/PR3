using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace idWatkuZadania
{


    internal class Program
    {

        static void WypiszInfo()
        {
            int idWatek = Thread.CurrentThread.ManagedThreadId;
            int? idZadanie = Task.CurrentId;

            Console.WriteLine("Wątek: {0}, Zadanie: {1}", idWatek, idZadanie);
            Thread.Sleep(10);
        }
        static void Main(string[] args)
        {

            Thread thread = new Thread(WypiszInfo);
            thread.Start();
            Task.Run(WypiszInfo);
            Task.Run(WypiszInfo);
            Thread.Sleep(1000); // musi byc bo 
            Task.Run(WypiszInfo);
            Task.Run(WypiszInfo);
            Task.Run(WypiszInfo);
            Task.Run(WypiszInfo);
            Thread.Sleep(1000);
            Task.Run(WypiszInfo);
            Task.Run(WypiszInfo);
            Task.Run(WypiszInfo);
            Task.Run(WypiszInfo);
            //Thread.Sleep(1000);
            Task.Run(WypiszInfo);
            Task.Run(WypiszInfo);
            Task.Run(WypiszInfo);
            Task.Run(WypiszInfo);
            Thread.Sleep(1000);
            Task.Run(WypiszInfo);
            Task.Run(WypiszInfo);
            Task.Run(WypiszInfo);
            Task.Run(WypiszInfo);
            //Thread.Sleep(1000);
            Task.Run(WypiszInfo);
            Task.Run(WypiszInfo);
            Task.Run(WypiszInfo);
            Task.Run(WypiszInfo);
            //Thread.Sleep(1000);
            Task.Run(WypiszInfo);
            Task.Run(WypiszInfo);


        }
    }
}

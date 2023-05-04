using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace watki
{
    class Program
    {
        static void MetodaWatku()
        {
            int j = 1;
            Thread.Sleep(50);
            for (int i = 1; i < 100000000; i++)
            {
                j *= i;
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(MetodaWatku));
            Console.Write("Stan przed uruchomieniem:\n ");
            Console.WriteLine(t.ThreadState);
            t.Start();
            Thread.Sleep(1);
            Console.Write("Stan w uśpieniu:\n ");
            Console.WriteLine(t.ThreadState);
            Thread.Sleep(60); // bo inaczej 
            Console.Write("Stan odczas pracy:\n ");
            Console.WriteLine(t.ThreadState);
            t.Join(); // join - czeka na zakończenie wątku 
            Console.Write("Stan po zatrzymaniu:\n ");
            Console.WriteLine(t.ThreadState);
        }
    }
}

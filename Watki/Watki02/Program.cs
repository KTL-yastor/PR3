using System;
using System.Threading;
class Program
{
    static void MetodaWatku()
    {
        Console.WriteLine("Wątek uruchomiony bez argumentu");
    }
    static void MetodaWatku1(object o)
    {
        //string tekst = o as string;
        Console.WriteLine("Wątek uruchomiony z argumentem \"{0}\"", o);
    }
    void MetodaWatku2(object o)
    {
        Console.WriteLine("Wątek uruchomiony z argumentem \"{0}\"", o);
    }
    static void Main(string[] args)
    {
        Thread t = new Thread(new ThreadStart(MetodaWatku));
        //Thread t = new Thread(MetodaWatku);
        t.Start();
        Thread t1 = new Thread(new ParameterizedThreadStart(Program.MetodaWatku1));
        //Thread t1 = new Thread(new ParameterizedThreadStart(MetodaWatku1));
        //Thread t1 = new Thread(Program.MetodaWatku1);
        //Thread t1 = new Thread(MetodaWatku1);
        t1.Start("jakiś argument ...");
        Program p = new Program();
        Thread t2 = new Thread(new ParameterizedThreadStart(p.MetodaWatku2));
        //Thread t2 = new Thread(p.MetodaWatku2);
        t2.Start(12.34);
        //t.Join(); t1.Join(); t2.Join();
    }
}

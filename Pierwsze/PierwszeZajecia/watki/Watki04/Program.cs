using System;
using System.Threading;
namespace WatkiPrzyklad4a
{
    public class Dane
    {
        private int a, b;
        private int wynik;
        public Dane(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Wartosc1
        {
            get { return this.a; }
        }
        public int Wartosc2
        {
            get { return this.b; }
        }
        public int Wynik
        {
            set { wynik = value; }
            get { return this.wynik; }
        }
    }
    class Program
    {
        static void MetodaWatku(object o)
        {
            Dane dane = o as Dane;
            Thread.Sleep(10);
            dane.Wynik = dane.Wartosc1 + dane.Wartosc2;
        }
        static void Main(string[] args)
        {
            Dane d1 = new Dane(1, 2);
            Dane d2 = new Dane(2, 3);
            ParameterizedThreadStart dodawanie = new ParameterizedThreadStart(MetodaWatku);
            Thread t1 = new Thread(dodawanie);
            Thread t2 = new Thread(dodawanie);
            t1.Start(d1);
            t2.Start(d2);
            t1.Join(); t2.Join(); // ważne(!)
            Console.WriteLine("{0}, {1}", d1.Wynik, d2.Wynik);
        }
    }
}
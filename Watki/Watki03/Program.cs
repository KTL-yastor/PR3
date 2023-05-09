using System;
using System.Text;
using System.Threading;
namespace WatkiPrzyklad3
{
    class KlasaWatku
    {
        private String argument = null;
        public KlasaWatku(String arg)
        {
            argument = arg;
        }
        public void Obliczenia()
        {
            Console.WriteLine("Wykonywane obliczenia dla: \"{0}\"", this.argument);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KlasaWatku w = new KlasaWatku("dane");
            Thread t = new Thread(w.Obliczenia);
            t.Start();
        }
    }
}
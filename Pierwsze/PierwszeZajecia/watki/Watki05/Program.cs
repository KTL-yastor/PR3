using System;
using System.Threading;

public delegate void delegacja(int wartosc);
public class KlasaWatku
{
    private string opis;
    private int wartosc;
    private delegacja wywolanieZwrotne;
    public KlasaWatku(string opis, int wart, delegacja del)
    {
        this.opis = opis;
        this.wartosc = wart;
        wywolanieZwrotne = del;
    }
    public void WykonanieWatku()
    {
        Console.WriteLine("Wykonanie wątku {0}", opis);
        if (wywolanieZwrotne != null)
            wywolanieZwrotne(wartosc);
    }
}
class Program
{
    public static void ZapisanieWyniku(int wartosc)
    {
        Console.WriteLine("Wynik wątku: {0}", wartosc);
    }
    static void Main(string[] args)
    {
        KlasaWatku w = new KlasaWatku("Watek ze zwracaniem wartosci",
            //12345, ZapisanieWyniku);
            12345, new delegacja(ZapisanieWyniku));
        //Thread t = new Thread(w.WykonanieWatku);
        Thread t = new Thread(new ThreadStart(w.WykonanieWatku));
        t.Start();
        t.Join();
    }
}
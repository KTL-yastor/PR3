using System;
using System.IO;
using System.Xml.Serialization;

namespace SerializacjaXMLKlasy
{
    public class Program // Musi być publiczna
    {
        public class Dane // Musi być publiczna
        {
            //int liczba;
            //DateTime data;
            //string lancuch;
            //double[] tablica;

            public int Liczba { get { return liczba; } }
            public DateTime Data { get { return data; } }
            public string Lancuch { get { return lancuch; } }
            public double[] Tablica { get { return tablica; } }

            public int liczba; // Muszą być publiczne 
            public DateTime data;
            public string lancuch;
            public double[] tablica;

            public Dane(int liczba, DateTime data, string lancuch, double[] tablica)
            {
                this.liczba = liczba;
                this.data = data;
                this.lancuch = lancuch;
                this.tablica = tablica;
            }

            public Dane() // Musi być zdefiniowany
            {
                this.liczba = 0;
                this.data = DateTime.MinValue;
                this.lancuch = String.Empty;
                this.tablica = null;
            }
        }

        static void Main(string[] args)
        {
            Serializacja();
            Deserializacja();
        }

        static void Serializacja()
        {
            int liczba = 12345;
            DateTime data = DateTime.Now;
            string lancuch = "Łańcuch danych";
            double[] tablica = { 1.0, 2.5, 3.2, 4.1 };

            Dane dane = new Dane(liczba, data, lancuch, tablica);
            FileStream fs = new FileStream("dane.xml", FileMode.Create);
            Type[] dodatkoweTypy = new Type[4]
               {
                 typeof(int),
                 typeof(DateTime),
                 typeof(string),
                 typeof(double[])
               };
            XmlSerializer xs = new XmlSerializer(typeof(Dane), dodatkoweTypy);
            xs.Serialize(fs, dane);
            fs.Close();
        }

        static void Deserializacja()
        {
            //int liczba, liczba2;
            //DateTime data;
            //string lancuch;
            //double[] tablica;

            FileStream fs = new FileStream("dane.xml", FileMode.Open);

            Type[] dodatkoweTypy = new Type[4]
               {
                 typeof(int),
                 typeof(DateTime),
                 typeof(string),
                 typeof(double[])
               };

            XmlSerializer xs = new XmlSerializer(typeof(Dane), dodatkoweTypy);
            Dane dane = (Dane)xs.Deserialize(fs);
            fs.Close();

            Console.WriteLine("liczba:  {0}", dane.Liczba);
            Console.WriteLine("data:    {0}", dane.Data);
            Console.WriteLine("łańcuch: {0}", dane.Lancuch);
            Console.Write("tablica: ");
            for (int i = 0; i < dane.Tablica.Length; i++)
            {
                Console.Write("\t " + dane.Tablica[i]);
            }
            Console.WriteLine();
        }
    }
}

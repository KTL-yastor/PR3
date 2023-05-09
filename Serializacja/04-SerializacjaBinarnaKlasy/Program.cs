using System;
using System.IO;
//using System.Runtime.Serialization;
//using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializacjaBinarnaKlasy
{
    class Program
    {
        [Serializable] // Musi być ustawiony atrybut Serializable
        class Dane     // Nie musi być publiczna
        {
            int liczba;     // Nie muszą być publiczne
            DateTime data;
            string lancuch;
            double[] tablica;

            public int Liczba { get { return liczba; } }
            public DateTime Data { get { return data; } }
            public string Lancuch { get { return lancuch; } }
            public double[] Tablica { get { return tablica; } }

            public Dane(int liczba, DateTime data, string lancuch, double[] tablica)
            {
                this.liczba = liczba;
                this.data = data;
                this.lancuch = lancuch;
                this.tablica = tablica;
            }
            // Nie musi być zdefiniowany
            //public Dane() 
            //{
            //    this.liczba = 0;
            //    this.data = DateTime.MinValue;
            //    this.lancuch = String.Empty;
            //    this.tablica = null;
            //}
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

            FileStream fs = new FileStream("dane.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, dane);

            fs.Close();
        }

        static void Deserializacja()
        {
            //int liczba, liczba2;
            //DateTime data;
            //string lancuch;
            //double[] tablica;

            FileStream fs = new FileStream("dane.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            Dane dane = (Dane)bf.Deserialize(fs);
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

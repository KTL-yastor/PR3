using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace _12_SerializacjaJSONKlasy
{
    class Program
    {
        [DataContract] // Musi być ustawiony atrybut DataContract
        class Dane     // Nie musi być publiczna
        {
            [DataMember]
            private int liczba;     // Nie muszą być publiczne
            [DataMember]
            private DateTime data;
            [DataMember]
            private string lancuch;
            [DataMember]
            private double[] tablica;

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
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Dane));

            ser.WriteObject(fs, dane);

            fs.Close();
        }

        static void Deserializacja()
        {
            FileStream fs = new FileStream("dane.dat", FileMode.Open);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Dane));

            Dane dane = (Dane)ser.ReadObject(fs);
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

using System;
using System.IO;
//using System.Runtime.Serialization;
//using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Soap; // Należy dodać też referencję

namespace SerializacjaSOAP
{
    class Program
    {
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

            FileStream fs = new FileStream("dane.dat", FileMode.Create);
            SoapFormatter sf = new SoapFormatter();

            sf.Serialize(fs, liczba);
            sf.Serialize(fs, data);
            sf.Serialize(fs, lancuch);
            sf.Serialize(fs, tablica);
            fs.Close();
        }

        static void Deserializacja()
        {
            int liczba;
            DateTime data;
            string lancuch;
            double[] tablica;

            FileStream fs = new FileStream("dane.dat", FileMode.Open);
            SoapFormatter sf = new SoapFormatter();

            liczba = (int)sf.Deserialize(fs);
            data = (DateTime)sf.Deserialize(fs);
            lancuch = (string)sf.Deserialize(fs);
            tablica = (double[])sf.Deserialize(fs);
            fs.Close();

            Console.WriteLine("liczba:  {0}", liczba);
            Console.WriteLine("data:    {0}", data);
            Console.WriteLine("łańcuch: {0}", lancuch);
            Console.Write("tablica: ");
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write("\t " + tablica[i]);
            }
            Console.WriteLine();
        }
    }
}

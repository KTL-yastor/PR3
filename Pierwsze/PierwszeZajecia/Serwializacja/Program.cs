using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serializacja
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
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, liczba);
            bf.Serialize(fs, data);
            bf.Serialize(fs, lancuch);
            bf.Serialize(fs, tablica);
            fs.Close();
        }

        static void Deserializacja()
        {
            int liczba;
            DateTime data;
            string lancuch;
            double[] tablica;

            FileStream fs = new FileStream("dane.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            liczba = (int)bf.Deserialize(fs);
            data = (DateTime)bf.Deserialize(fs);
            lancuch = (string)bf.Deserialize(fs);
            tablica = (double[])bf.Deserialize(fs);
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

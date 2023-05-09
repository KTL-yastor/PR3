using System;
using System.IO;
using System.Runtime.Serialization; // [OptionalField]
//using System.Runtime.Serialization.Formatters;
//using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace AtrybutOptional
{
    class Program
    {
        [Serializable] 
        class Dane 
        {
            private int liczba1, liczba2;  
            [OptionalField]
            private int suma, roznica, iloczyn;

            public int Liczba1 { get { return liczba1; } }
            public int Liczba2 { get { return liczba2; } }
            public int Suma { get { return suma; } }
            public int Roznica { get { return roznica; } }
            public int Iloczyn { get { return iloczyn; } }

            public Dane(int liczba1, int liczba2)
            {
                this.liczba1 = liczba1;
                this.liczba2 = liczba2;
                suma = liczba1 + liczba2;
                roznica = liczba1 - liczba2;
                iloczyn = liczba1 * liczba2;
            }

        }

        static void Main(string[] args)
        {
            //if (Console.ReadKey() == ConsoleKey.Enter)
            if (!File.Exists("dane.dat"))
            {
                Console.WriteLine("Serializacja");
                Serializacja();
            }
            else
            {
                Console.WriteLine("Deserializacja");
                Deserializacja();
            }
        }

        static void Serializacja()
        {
            int liczba1 = 5;
            int liczba2 = 3;
            Dane dane = new Dane(liczba1, liczba2);

            FileStream fs = new FileStream("dane.dat", FileMode.Create);
            SoapFormatter sf = new SoapFormatter();

            sf.Serialize(fs, dane);

            fs.Close();
        }

        static void Deserializacja()
        {
            FileStream fs = new FileStream("dane.dat", FileMode.Open);
            SoapFormatter sf = new SoapFormatter();

            Dane dane = (Dane)sf.Deserialize(fs);
            fs.Close();

            Console.WriteLine("liczba1:  {0}", dane.Liczba1);
            Console.WriteLine("liczba2:  {0}", dane.Liczba2);
            Console.WriteLine("suma:     {0}", dane.Suma);
            Console.WriteLine("roznica:  {0}", dane.Roznica);
            Console.WriteLine("iloczyn:  {0}", dane.Iloczyn);
        }
    }
}
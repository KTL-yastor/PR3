using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializacjaXML
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

            //XmlSerializer xs = new XmlSerializer();  // błąd
            XmlSerializer xsInt = new XmlSerializer(typeof(int));
            XmlSerializer xsDateTime = new XmlSerializer(typeof(DateTime));
            XmlSerializer xsString = new XmlSerializer(typeof(string));
            XmlSerializer xsTable = new XmlSerializer(typeof(double[]));

            FileStream fs1 = new FileStream("dane1.xml", FileMode.Create);
            xsInt.Serialize(fs1, liczba);
            //xsInt.Serialize(fs1, 1234567);
            fs1.Close();

            FileStream fs2 = new FileStream("dane2.xml", FileMode.Create);
            xsDateTime.Serialize(fs2, data);
            fs2.Close();

            FileStream fs3 = new FileStream("dane3.xml", FileMode.Create);
            xsString.Serialize(fs3, lancuch);
            fs3.Close();

            FileStream fs4 = new FileStream("dane4.xml", FileMode.Create);
            xsTable.Serialize(fs4, tablica);
            fs4.Close();
        }

        static void Deserializacja()
        {
            int liczba, liczba2;
            DateTime data;
            string lancuch;
            double[] tablica;

            //XmlSerializer xs = new XmlSerializer();  // błąd
            XmlSerializer xsInt = new XmlSerializer(typeof(int));
            XmlSerializer xsDateTime = new XmlSerializer(typeof(DateTime));
            XmlSerializer xsString = new XmlSerializer(typeof(string));
            XmlSerializer xsTable = new XmlSerializer(typeof(double[]));

            FileStream fs1 = new FileStream("dane1.xml", FileMode.Open);
            liczba = (int)xsInt.Deserialize(fs1);
            //liczba2 = (int)xsInt.Deserialize(fs1);

            Console.WriteLine("liczba:  {0}", liczba);
            fs1.Close();

            FileStream fs2 = new FileStream("dane2.xml", FileMode.Open);
            data = (DateTime)xsDateTime.Deserialize(fs2);
            Console.WriteLine("data:    {0}", data);
            fs2.Close();

            FileStream fs3 = new FileStream("dane3.xml", FileMode.Open);
            lancuch = (string)xsString.Deserialize(fs3);
            Console.WriteLine("łańcuch: {0}", lancuch);
            fs3.Close();

            FileStream fs4 = new FileStream("dane4.xml", FileMode.Open);
            tablica = (double[])xsTable.Deserialize(fs4);
            Console.Write("tablica: ");
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write("\t " + tablica[i]);
            }
            Console.WriteLine();
            fs4.Close();
        }
    }
}

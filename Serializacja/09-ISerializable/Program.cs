using System;
using System.IO;
using System.Runtime.Serialization; // IDeserializationCallback
//using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Security.Permissions;

namespace ISerializableExample
{
    class Program
    {
        [Serializable] 
        class Dane : ISerializable 
        {
            [NonSerialized]
            private int liczba1, liczba2;     
            [NonSerialized]
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

            public Dane(SerializationInfo sinfo, StreamingContext ctx)
            {
                Console.WriteLine("    pobieranie informacji");
                liczba1 = sinfo.GetInt32("L1");
                liczba2 = sinfo.GetInt32("L2");
                suma = liczba1 + liczba2;
                roznica = liczba1 - liczba2;
                iloczyn = liczba1 * liczba2;
            }

            //[SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
            void ISerializable.GetObjectData(SerializationInfo sinfo, StreamingContext ctx)
            {
                Console.WriteLine("    dodawanie informacji");
                sinfo.AddValue("L1", liczba1);
                sinfo.AddValue("L2", liczba2);
            }

            // Nie dziedziczymy po interfejsie IDeserializationCallback,
            // na skutek czego poniższa metoda nie zostanie wywołana
            public void OnDeserialization(object sender)
            {
                Console.WriteLine("Wyliczanie operacji");
                suma = liczba1 + liczba2;
                roznica = liczba1 - liczba2;
                iloczyn = liczba1 * liczba2;
            }

            [OnSerializing]
            internal void MyOnSerializing(StreamingContext context)
            {
                Console.WriteLine("  MyOnSerializing");
            }

            [OnSerialized]
            internal void MyOnSerialized(StreamingContext context)
            {
                Console.WriteLine("  MyOnSerialized");
            }

            [OnDeserializing]
            internal void MyOnDeserializing(StreamingContext context)
            {
                Console.WriteLine("  MyOnDeserializing");
            }

            [OnDeserialized]
            internal void MyOnDeserialized(StreamingContext context)
            {
                Console.WriteLine("  MyOnDeserialized");
            }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Serializacja");
            Serializacja();
            Console.WriteLine("Deserializacja");
            Deserializacja();
        }

        static void Serializacja()
        {
            int liczba1 = 5;
            int liczba2 = 3;
            Dane dane = new Dane(liczba1, liczba2);

            FileStream fs = new FileStream("dane.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, dane);

            fs.Close();
        }

        static void Deserializacja()
        {
            FileStream fs = new FileStream("dane.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            Dane dane = (Dane)bf.Deserialize(fs);
            fs.Close();

            Console.WriteLine("liczba1:  {0}", dane.Liczba1);
            Console.WriteLine("liczba2:  {0}", dane.Liczba2);
            Console.WriteLine("suma:     {0}", dane.Suma);
            Console.WriteLine("roznica:  {0}", dane.Roznica);
            Console.WriteLine("iloczyn:  {0}", dane.Iloczyn);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutGeneryczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = {1, 2, 3, 4, 5, 6, 7, 8, 8, 8, 9};
            int maks;
            //Max(out maks, 2,2,2,2,3,4,4,4,56,4576,456,456,456,456,456456);
            //Console.WriteLine("Maksymalna wartosc to {0}", maks);
            FindMax<int>(out maks, tab);
            Console.WriteLine("Maksymalna wartosc to {0}", maks);

            // tablica osob

            Person[] people = {
                new Person (1, "Jan", 20),
                new Person (2, "Anna", 30),
                new Person (3, "Krzysztof", 40)
            };

            Person najstarsza = new Person();

            FindMaxPeople<Person> (out najstarsza, people);

            Console.WriteLine("Najstarsza osoba to {0}", najstarsza);

        }

        static void Max(out int maksimum, params int[] elements) 
        {
            maksimum = Int32.MinValue;
            if (elements == null)
            {
                Console.WriteLine("Brak podanych argumentow");
                return;
            }
            foreach (int el in elements)
            { 
                if (el > maksimum) maksimum = el;
            }
        }

        static void FindMax<T>(out T maks, params T[] elements) where T: IComparable<T>
        {
            //nie znam typu więc musze przypisac pierwszy element z tablicy pod maks
            maks = elements[0];
            foreach (T el in elements)
            {
                if (maks.CompareTo(el) < 0) maks = el;
            }
        }

        static void FindMaxPeople<T>(out T maks, params T[] elements) where T : Porownywarka<T>
        {
            //nie znam typu więc musze przypisac pierwszy element z tablicy pod maks
            maks = elements[0];
            foreach (T el in elements)
            {
                if (maks.Porownaj(el) < 0) maks = el;
            }
        }
    }
}

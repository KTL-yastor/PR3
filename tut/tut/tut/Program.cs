using System;

namespace tut
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Podaj dlugosc boku kwadratu");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Pole kwadratu wynosi: " + a * a);
            Console.WriteLine($"Podales {a} jako dlugosc boku kwadratu");
        }
    }

}
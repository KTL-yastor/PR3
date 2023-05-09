using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Watki2
{
    internal class Program
    {
        static void Wypisz(object n)
        {
            string napis = (string)n;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(napis);
                Thread.Sleep(10);
                Console.WriteLine(Thread.CurrentThread.Name);
            }
        }

        static int Dodawanie(int a, int b)
        { return a + b; }




        static string Napis(string napis) {
            return napis;
        }

        Task<string> Wypisz(string napis)
        { 
            return Task.Run(() => Napis(napis));
        }

        delegate void MojaDelegata(int arg1, string arg2);

        static void MojaMetoda(int arg1, string arg2)
        {
            Console.WriteLine("Wywołano metodę z argumentami: {0}, {1}", arg1, arg2);
        }


        static void Main(string[] args)
        {
            Thread thread = new Thread(Wypisz);
            thread.Name = "Watek 1";
            thread.Priority = ThreadPriority.BelowNormal;
            thread.Start("aaaaa");
            thread.Join();

            Console.Write(thread.Name);
            Console.WriteLine(thread.ThreadState);
            Console.WriteLine("Koniec");

            Thread thread2 = new Thread(()=>
            { int a = Dodawanie(4 , 3);
                Console.WriteLine(a);
            });
            thread2.Start();
            thread2.Join();


            
            Task<string> zadanie = Task<string>.Factory.StartNew(() =>
            {
                string imie = Napis("imasie");

                return imie;

            });

            Console.WriteLine(zadanie.Result);

            MojaDelegata delegat = MojaMetoda;

            Thread thread3 = new Thread(() => delegat(42, "test"));
            thread3.Start();

            Console.WriteLine("Koniec programu");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace delegate_anonim
{
    class Program
    {
        static void Main()
        {
            /*// Stworzenie wątku za pomocą metody anonimowej delegate
            Thread thread1 = new Thread(delegate ()
            {
                PrintNumbers();
            });

            // Stworzenie wątku za pomocą wyrażenia lambda
            Thread thread2 = new Thread(() =>
            {
                PrintNumbers();
            });

            // Uruchomienie wątków
            thread1.Start();
            thread2.Start();

            // Oczekiwanie na zakończenie wątków
            thread1.Join();
            thread2.Join();*/

            // stworzenie delegata dla watku ktory uruchomi metode z parametrem
            
            ParameterizedThreadStart funkcja = new ParameterizedThreadStart(WypiszeLiczbe); // delegat ktory przyjmuje parametr
            Thread thread3 = new Thread(funkcja);
            thread3.Start(5);

        }

        static void PrintNumbers()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void WypiszeLiczbe(object n)
        {
            Console.WriteLine(n);
        }
    }
}

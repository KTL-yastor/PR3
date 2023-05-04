using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new task 
            Task<long> task = new Task<long>(() =>
            {
                long iloczyn = 1;
                //wypisanie liczb od 1 do 100
                for (int i = 1; i <= 10; i++)
                {
                    iloczyn *= i;
                }
                return iloczyn;
            });
            
            // new thread
            Thread watek = new Thread(() => {
                //wypisanie liczb od 1 do 100
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            });
            // task taki sam jak watek
            Task task2 = new Task(() =>
            {
                //wypisanie liczb od 1 do 100
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            });

            task2.Start();
            task2.Wait();
            task.Start();
            Console.WriteLine($"10 silnia = {task.Result}");

            //watek.Start();
            

        }
    }
}

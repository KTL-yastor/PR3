using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argumenty
{
    internal class Argumenty
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Liczba argumentów: " + args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Argument " + i + ": " + args[i]);
            }
            // foreach
            foreach (string arg in args)
            {
                Console.WriteLine("Argument: " + arg);
            }
            Console.ReadLine();
        }
    }
}

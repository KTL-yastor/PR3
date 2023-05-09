using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatyAnonimy
{
    delegate void Anonim(int n);
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Anonim test = (x) => Console.WriteLine(x);
            test(5);
            Anonim test2 = delegate (int x) { Console.WriteLine(x); };
            test2(5);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabliczkaMnozenia
{
    internal class Tabliczka
    {
        private int n;

        private int m;

        public Tabliczka(int n, int m) {
            this.n = n;
            this.m = m;

        }

        public void WyswietlTabliczke() 
        {
            for ( int i = 1; i <= n; i ++ ) 
            { 
                for ( int j = 1; j <= m; j ++ ) 
                {
                    Console.Write($" {i * j,4} ");
                }
                Console.WriteLine();
            }
        }
    }
}

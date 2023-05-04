using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace watki
{
    class licznik
    {
        // klasa przyjmuje liczbe startową i co ile ma zwiększać licznik
        public int start { get; set; }
        public int step { get; set; }
        //public int actual { get; set; }
        public licznik(int start, int step = 1)
        {
            this.start = start;
            this.step = step;
        }
        // konsttruktor bez parametrów
        public licznik()
        {
            this.start = 0;
            this.step = 1;
        }
        // metoda zwiekszajaca aktualną wartość licznika i printująca ją
        public void count(bool print = true)
        {
            this.start += this.step;
            if (print)
            {
                Console.WriteLine(this.start);
            }
            
        }
        // petla zwiekszajaca licnzik do 100 co step
        public void countTo100w(object print)
        {
            while (this.start < 100)
            {
                this.count((bool)print);
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal abstract class Duch
    {
        protected string imie; // protected - dostepne w klasie i klasach pochodnych

        public Duch(string imie)
        {
            this.imie = imie;
        }

        public void Test()
        {
            Console.WriteLine("test");
        }

        public abstract void PodajImie();
    }
}

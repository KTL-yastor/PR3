using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal zwierz =     new Animal("kazik");

            zwierz.MakeSound();

            Dog pies = new Dog("adam");

            pies.MakeSound();

            Animal reksio = new Dog("malysz");

            reksio.MakeSound();


            //
            Animal[] animals = { new Dog("kazik"), new Animal("animal"), new Duck("lala"), new Dog("alex") };

            foreach (Animal a in animals)
            { 
                a.MakeSound();
                a.PodajImie();
                a.Test();
                
            }

            Duch d = new Dog("RYsiu");
            d.PodajImie();
            Dog pp = new Dog("aa");
            Console.WriteLine(pp.Zeby);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Animal : Duch
    {
        public Animal(string imie) : base(imie) {  }

        

        public virtual void MakeSound() {
            Console.WriteLine("Rawr");
        }

        public override void PodajImie()
        {
            Console.WriteLine(imie);
        }
    }

    class Dog : Animal
    { 
        public int Zeby { get; set; }
        public Dog(string imie) : base(imie) { Zeby = 2; }

        public Dog(string imie, int zeby) : base(imie)
        {
            Zeby = zeby;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof");
        }
    }

    class Duck : Animal
    { 
        public Duck(string imie) : base(imie) { }

        public override void MakeSound()
        {
            
            Console.WriteLine("Quack");
        }

        
    }
}

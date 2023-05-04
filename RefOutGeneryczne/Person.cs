using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutGeneryczne
{
    internal class Person : Porownywarka<Person>, IComparable<Person>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(int id, string name, int age)
        { 
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public Person()
        {
        }

        public override string ToString()
        {

            return "Osoba "+ Name + " od id: "+ Id + " ma lat: "+Age;
        }

        public int CompareTo(Person other)
        {
            if (other == null) return 1;

            if (other.Age == this.Age) return 0;

            if (other.Age > this.Age) return -1;

            if ((other.Age < this.Age)) return 1;

            return 0;
        }
        public int Porownaj(Person other)
        {
            if (other == null) return 1;

            if (other.Age == this.Age) return 0;

            if (other.Age > this.Age) return -1;

            if ((other.Age < this.Age)) return 1;

            return 0;
        }

    }
}

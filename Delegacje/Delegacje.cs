using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegacje
{
    class Klasa1
    {
        public void Akcja1()
        {
            System.Console.WriteLine("Klasa1 - akcja1");
        }
    }

    class Klasa2
    {
        public void Akcja2()
        {
            System.Console.WriteLine("Klasa2 - akcja2");

        }

    }

    class Delegacje
    {
        /*
        Delegacje są jak "wskaźniki do funkcji": Można je traktować jako zmienne, które przechowują referencje do metod.
        Dzięki temu można przekazać metodę jako argument do innej metody lub przechować ją w zmiennej, aby ją później wywołać.*/

        //Delegacje definiują "sygnaturę" metody: Przy tworzeniu delegacji określa się, jakiej sygnatury metody może ona przechowywać.
        //Sygnatura to informacje o typie zwracanej wartości oraz typach i kolejności parametrów metody.
        //Dzięki temu delegacja może być używana tylko do przechowywania i wywoływania metod o takiej samej sygnaturze.
        delegate void delegacja(); // tutaj tworze 

        private delegacja instancjaDelegacji;
        private Klasa1 kl1;
        private Klasa2 kl2;


        public Delegacje()
        {
            kl1 = new Klasa1();
            kl2 = new Klasa2();

            this.instancjaDelegacji += kl1.Akcja1;
            this.instancjaDelegacji += kl2.Akcja2;

        }

        public void UzycieDelegacji() 
        {
            this.instancjaDelegacji();
        }

        public void DodanieDelegacjiLambda()
        {

            this.instancjaDelegacji += () =>
            {
                Console.WriteLine("Funkcja Lambda dodana do delegacji");
            };


        }




    }
}

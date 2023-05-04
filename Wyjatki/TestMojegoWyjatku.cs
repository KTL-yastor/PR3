using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    internal class TestMojegoWyjatku
    {
        private Random r;
        public TestMojegoWyjatku()
        {
            r = new Random(); 
        }

        public void Test()
        {
            //losowanie 2 liczb double z przedzialu [0,1);
            
            double a = r.NextDouble();
            double b = r.NextDouble();
            if (a * a + b * b < 1)
            {
                throw new MojException();
            }
        }
    }
}

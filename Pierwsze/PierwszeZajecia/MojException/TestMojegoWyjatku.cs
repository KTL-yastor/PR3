using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojException
{
    internal class TestMojegoWyjatku
    {
        private Random random = new Random();

        public void Test()
        {
            double x = random.NextDouble();
            double y = random.NextDouble();

            if (x * x + y * y < 1)
            {
                throw new MojException("TEST!!!!!!!!!!!!");
            }
        }
    }
}

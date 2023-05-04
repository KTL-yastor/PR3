using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    internal class LapanieWyjatkow
    {
        public int Podziel(int[] a)
        {
            int iloczyn_wynik = 1;
            try {
                checked { 
                    foreach (int el in a)
                    { 
                        iloczyn_wynik *= el;
                    }
                    a[0] = a[0] + a[1] * a[2] * a[3] / a[4];
                    }
            }
            catch (OverflowException) 
            {
                Console.WriteLine("Złapano wyjątek OverflowException");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Złapano wyjątek DivideByZeroException");
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Złapano wyjątek ArithmeticException");
                throw e;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Złapano wyjątek NullReferenceException");
                throw e;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Złapano wyjątek IndexOutOfRangeException");
            }
            catch (Exception e)
            {
                Console.WriteLine("Złapano inny wyjątek ({0})",
                    e.GetType().Name.ToString());
            }

            return iloczyn_wynik;

        }
    }
}

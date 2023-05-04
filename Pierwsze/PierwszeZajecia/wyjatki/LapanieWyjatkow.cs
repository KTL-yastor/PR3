using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyjatki
{
    public class LapanieWyjatkow
    {
        public int Podziel(int[] liczby)
        {
            int iloczyn = 1;
            try
            {
                checked
                { 
                for (int i = 0; i < liczby.Length; i++)
                {

                    iloczyn *= liczby[i];
                }

                liczby[0] = liczby[0] + liczby[1] * liczby[2] * liczby[3] / liczby[4];
                }
            }
            catch (Exception ex) when (ex is OverflowException)
            {
                Console.WriteLine("OverflowException: " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException: " + ex.Message);
                throw ex;
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("ArithmeticException: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException: " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            return iloczyn;
        
    }
    }
}

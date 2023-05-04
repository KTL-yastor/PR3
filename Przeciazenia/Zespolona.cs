using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przeciazenia
{
    internal class Zespolona
    {
        private double re, im;
        public Zespolona(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        public Zespolona(double re)
        {
            this.re = re;
            this.im = 0;
        }
        public override string ToString()
        {
            return "(" + re + "," + im + ")";
        }
        public static Zespolona operator +(Zespolona a, Zespolona b)
        {
            return new Zespolona(a.re + b.re, a.im + b.im);
        }
        // definicja domyślnej konwersji
        public static implicit operator Zespolona(double a)
        {
            return new Zespolona(a);
        }
        public static Zespolona operator -(Zespolona a, Zespolona b)
        {
            return new Zespolona(a.re - b.re, a.im - b.im);
        }
        // operatory ++ i -- wystarczy raz przeciążyć
        public static Zespolona operator ++(Zespolona a)
        {
            a.re++;
            return a; // należy zmienić na
                      // return new Zespolona(a.re, a.im);
        }
        public static Zespolona operator --(Zespolona a)
        {
            a.re--;
            return a; // należy zmienić
        }
        // operatory == i != muszą być przeciążane jednocześnie
        public static bool operator ==(Zespolona a, Zespolona b)
        {
            return a.re == b.re && a.im == b.im;
        }
        public static bool operator !=(Zespolona a, Zespolona b)
        {
            return a.re != b.re || a.im != b.im;
        }
        override public bool Equals(object a)
        {
            return this.re == ((Zespolona)a).re && this.im == ((Zespolona)a).im;
        }
        override public Int32 GetHashCode()
        {
            return this.re.GetHashCode() + this.im.GetHashCode();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class Complex
    {
        int re, im;

        public Complex(int re, int im)
        {
            this.re = re;
            this.im = im;
        }

        public override bool Equals(object obj)
        {
            var complex = obj as Complex;
            return complex != null &&
                   re == complex.re &&
                   im == complex.im;
        }

        public override int GetHashCode()
        {
            var hashCode = -196947237;
            hashCode = hashCode * -1521134295 + re.GetHashCode();
            hashCode = hashCode * -1521134295 + im.GetHashCode();
            return hashCode;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.re + b.re, a.im + b.im);
        }

        public static bool operator==(Complex a, Complex b)
        {
            return (a.re == b.re && a.im == b.im);
        }

        public static bool operator!=(Complex a, Complex b)
        {
            return (a.re != b.re && a.im != b.im);
        }
    }
}

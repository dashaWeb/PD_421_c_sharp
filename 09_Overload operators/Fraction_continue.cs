using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Overload_operators
{
    partial class Fraction
    {
        public static Fraction operator +(Fraction a, Fraction b)
        {
            /*int num = a.num *  b.denom + b.num * a.denom;
            int denom = a.denom * b.denom;*/
            //return new Fraction(num, denom);
            return new Fraction(a.num * b.denom + b.num * a.denom, a.denom * b.denom);
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            if (a.num == b.num && a.denom == b.num) return true;
            return false;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }
        public static Fraction operator ++(Fraction a)
        {
            //return new Fraction(a.num + 1, a.denom + 1);
            Fraction b = new Fraction(1, 1);
            return a + b;
        }
        public static bool operator true(Fraction a)
        {
            return a.num != 0;
        }
        public static bool operator false(Fraction a)
        {
            return a.num == 0;
        }
        // type Fraction -> other type
        public static explicit operator int(Fraction a)
        {
            return a.num / a.denom;
        }
        public static implicit operator double(Fraction a)
        {
            return (double)a.num / a.denom;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Calc
    {
        public Polynomial Summa(Polynomial a, Polynomial b, int headPow)
        {
            Polynomial sum = new Polynomial(headPow);
            sum = a + b;
            return sum;
        }
        public Polynomial Raznost(Polynomial a, Polynomial b, int headPow)
        {
            Polynomial raznost = new Polynomial(headPow);
            raznost = a - b;
            return raznost;
        }
        public Polynomial Multiply(Polynomial a, Polynomial b, int headPow)
        {
            Polynomial multi = new Polynomial(headPow);
            multi = a * b;
            return multi;
        }
        public Polynomial Multiply(Polynomial a, double b, int headPow)
        {
            Polynomial multi = new Polynomial(headPow);
            multi = a * b;
            return multi;
        }
        public Polynomial Multiply(double a, Polynomial b, int headPow)
        {
            Polynomial multi = new Polynomial(headPow);
            multi = a * b;
            return multi;
        }
        public void Division(Polynomial a, Polynomial b, ref double[] quotient, ref double[] remainder )
        {
            Polynomial.Division(a, b, ref quotient, ref remainder);
        }
        public Polynomial Stepen(Polynomial a, int b, int headPow)
        {
            Polynomial vozvedenie = new Polynomial(headPow);
            vozvedenie = a ^ b;
            return vozvedenie;
        }

    }
}

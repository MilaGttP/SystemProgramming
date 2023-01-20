using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyLoadLibrary
{
    public class Fraction
    {
        public int numerator { get; set; }
        public int denominator { get; set; }

        public Fraction()
        {
            numerator= 0;
            denominator= 1;
        }
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0) throw new DivideByZeroException();
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            int r1 = (int)a.numerator * b.denominator + (int)b.numerator * a.denominator;
            int r2 = (int)a.denominator * b.denominator;
            return new Fraction(r1, r2);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            int r1 = (int)a.numerator * b.denominator - (int)b.numerator * a.denominator;
            int r2 = (int)a.denominator * b.denominator;
            return new Fraction(r1, r2);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            int r1 = (int)a.numerator * b.numerator;
            int r2 = (int)a.denominator * b.denominator;
            return new Fraction(r1, r2);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            int r1 = (int)a.numerator * b.denominator;
            int r2 = (int)a.denominator * b.numerator;

            if (r2 == 0) throw new DivideByZeroException();
            else return new Fraction(r1, r2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyLoadLibrary
{
    public static class FactorialSimple
    {
        public static int Factorial(int number)
        {
            int i, fact = 1;
            for (i = 1; i <= number; i++) fact = fact * i;
            return fact;
        }
        public static bool IsPrime(int number)
        {
            int i, m = 0, flag = 0;
            m = number / 2;
            for (i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    flag = 1;
                    return false;
                }
                else return true;
            }
            if (flag == 0) return true;
            else return false;
        }
        public static bool IsEven(int number)
        {
            if (number % 2 == 0) { return true; }
            return false;
        }
        public static bool IsOdd(int number)
        {
            if (number % 2 != 0) { return true; }
            return false;
        }
    }
}

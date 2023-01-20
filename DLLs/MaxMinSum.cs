using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyLoadLibrary
{
    public static class MaxMinSum
    {
        public static int Max(int a, int b, int c)
        {
            int[] array = new int[] { a, b, c };
            return Enumerable.Max<int>(array);
        }
        public static int Min(int a, int b, int c)
        {
            int[] array = new int[] { a, b, c };
            return Enumerable.Min<int>(array);
        }
        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}

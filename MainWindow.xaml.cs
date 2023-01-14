
using System.Threading;
using System.Windows;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SystemProgramming
{
    public partial class MainWindow : Window
    {
        static List <uint> simpleNumbers;
        static List <uint> fibonacciNumbers;
        ThreadStart simpleTrStart;
        ThreadStart fibonacciTrStart;
        Thread simpleTr;
        Thread fibonacciTr;
        static int lowLimit;
        static int highLimit;
        public MainWindow()
        {
            InitializeComponent();
            simpleNumbers = new List <uint> ();
            fibonacciNumbers = new List <uint> ();
            simpleTrStart = new ThreadStart(GenerateSimple);
            fibonacciTrStart = new ThreadStart(GenerateFibonacci);
            simpleTr = new Thread(simpleTrStart);
            fibonacciTr = new Thread(fibonacciTrStart);
            lowLimit= 0;
            highLimit= 0;
        }
        public static bool IsPrime(uint number)
        {
            if (number <= 1) { return false; }

            int counter = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) { counter++; }
                if (counter > 2) { return false; }
            }

            return true;
        }
        public static void GenerateSimple()
        {
            if (highLimit == 0)
            {
                if (lowLimit == 0)
                {
                    while (true)
                    {
                        for (uint i = 2; i < 1000000000; i++)
                        {
                            if (IsPrime(i)) { simpleNumbers.Add(i); }
                        }
                    }
                }
                else
                {

                }
            }
            else
            {
                if (lowLimit == 0)
                {

                }
                else
                {

                }
            }
        }
        public static void GenerateFibonacci()
        {
            if (highLimit == 0)
            {
                if (lowLimit == 0)
                {

                }
                else
                {

                }
            }
            else
            {
                if (lowLimit == 0)
                {

                }
                else
                {

                }
            }
        }


    }
}

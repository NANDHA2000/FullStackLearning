using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Coding.FibonacciSeries
{
    public static class FibonacciSeries
    {
        public static void FibonacciSeriesEx() 
        {
            int n = 10;
            int a = 0, b = 1;
            Console.WriteLine("Fibonacci Series");
            for(int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int c = a + b;
                a = b;
                b = c;
            }

        /*  OutPut: -Fibonacci Series
              0 1 1 2 3 5 8 13 21 34
        */
        }
    }
}

using System;
using System.Diagnostics;

namespace Recursions
{

    //ZADATAK 1.


    internal class Program
    {
        static int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

        static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return (Fibonacci(n - 1) + Fibonacci(n - 2));
        }

        static int FibonacciIter(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            int a = 0;
            int b = 1;
            int result = 0;

            for (int i = 2; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }

            return result;
        }
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int result = Factorial(6);
            Console.WriteLine("Result using method Factorial of number 6 is " + result);

            stopwatch.Start();
            result = Fibonacci(50);
            stopwatch.Stop();
            Console.WriteLine("Result using method Fibonacci of number 50 is " + result);
            Console.WriteLine("Time taken for Fibonacci recursive: " + stopwatch.ElapsedMilliseconds + "ms");

            stopwatch.Reset();
            stopwatch.Start();
            result = FibonacciIter(50);
            stopwatch.Stop();
            Console.WriteLine("Result using method FibonacciIter of number 50 is " + result);
            Console.WriteLine("Time taken for Fibonacci iterative: " + stopwatch.ElapsedMilliseconds + "ms");
        }
    }
}

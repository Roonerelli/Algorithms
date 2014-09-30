using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Fibonacci
    {
        private readonly Dictionary<int, int> _cache = new Dictionary<int, int>();

        public int FibonacciRec(int n)
        {
            return n <= 2 ? 1 : FibonacciRec(n - 1) + FibonacciRec(n - 2);
        }

        public int FibonacciRecWithCaching(int n)
        {
            if (n <= 2)
                return 1;

            if (_cache.ContainsKey(n))
                return _cache[n];

            int fib = FibonacciRec(n - 1) + FibonacciRec(n - 2);
            _cache.Add(n, fib);
            return fib;
        }

        public int FibonacciIterative(int n)
        {
            if (n < 0)
                throw new Exception("n must be a positive int");

            if (n <= 2)
                return 1;

            int prev = 1;
            int fib = 1;

            for (int i = 2; i < n; i++)
            {
                var tmp = fib;
                fib += prev;
                prev = tmp;
            }

            return fib;
        }
    }
}
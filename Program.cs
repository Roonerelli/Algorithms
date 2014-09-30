using System;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = new[] { 0, 99, 79, 12, 3, 4, 33, 64, 22, 5, 84, 40 };
            Array.Sort(ints);
            
            var bins = new BinarySearch();
            Console.Write(bins.Iterative(ints, 5));

            //var algos = new Fibonacci();
            //Console.Write(algos.FibonacciRec(49));
            Console.Read();
        }
    }
}
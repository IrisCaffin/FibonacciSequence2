using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence2
{
    class Program
    {
        public static int FibonacciSequence2(int n)
        {
            if (n == 0) return 0; // To return the first Fibonacci number
            if (n == 1) return 1; // To return the second Fibonacci number
            return FibonacciSequence2(n - 1) + FibonacciSequence2(n - 2);
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter the length of the Fibonacci Sequence: ");
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", FibonacciSequence2(i));
            }
            Console.ReadKey();
        }
    }
}

// Project Euler Problem 6
// Find the difference between the square of the sums of the first 100 natural numbers (1 + 2 + 3 + 4 + ... + 100)^2
// and the square of the sums of the first 100 natural numbers (1^2 + 2^2 + 3^2 + ... + 100^2)...

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class EulerSix
    {
        static ulong sumOfSq = 0;
        static ulong sqOfSum = 0;
        static ulong diff;

        public static void SumOfSquares(ulong max)
        {
            for (ulong i = 1; i <= max; i++)
            {
                sumOfSq += (i * i);
            }
        }

        public static void SquareOfSum(ulong max)
        {
            // Used the Gaussian identity of the sum of the first n numbers = (n * (n + 1)) / 2
            sqOfSum = (max * (max + 1)) / 2;
            sqOfSum = sqOfSum * sqOfSum;
        }

        public static ulong Difference()
        {
            diff = sqOfSum - sumOfSq;
            return diff;
        }

        static void Main(string[] args)
        {
            SumOfSquares(100);
            SquareOfSum(100);
            Console.WriteLine(sqOfSum);
            Console.WriteLine(sumOfSq);
            Console.WriteLine("The difference is: " + Difference());
            Console.ReadLine();
        }
    }
}

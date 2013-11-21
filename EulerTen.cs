using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerTen
{
    class Program
    {
        static long sum = 0;
        static public bool isPrime(long n)
        {
            for (long i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        public static void Main()
        {
            for (long j = 2; j < 2000000; j++)
            {
                if (isPrime(j))
                {
                    sum = sum + j;
                }
            }
            Console.Write("sum = " + sum);
            Console.ReadLine();
        }
    }
}

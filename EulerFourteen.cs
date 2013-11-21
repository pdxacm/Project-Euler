using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerFourteen
{
    class EulerFourteen
    {
        static long num = 13, numTerms = 0;
        static long temp;
        static Dictionary<long, long> solution = new Dictionary<long, long>();

        public static void processNumber()
        {
            numTerms = 0;
            while (num != 1)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                    numTerms++;
                }
                else
                {
                    num = (3 * num) + 1;
                    numTerms++;
                }
            }
            solution.Add(temp, numTerms);
        }
        public static void Main()
        {
            for (long i = 2; i < 1000000; i++)
            {
                num = i;
                temp = num;
                processNumber();
            }
            Console.Write("Max value: ");
            Console.WriteLine(solution.Values.Max());
            // I LOVE LINQ
            var key = solution.Where(p => p.Value == 524).Select(p => p.Key);

            Console.Write("Corresponding key:");
            foreach (var k in key)
                Console.WriteLine(k);
            Console.Read();
        }
    }
}

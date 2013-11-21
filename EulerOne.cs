// Project Euler Problem #1
// Calculate the sum of the multiples of 3 and 5 below 1000 exclusive.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class EulerOne
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                    sum += i;
            }
            Console.WriteLine("The sum of the multiples of 3 and 5 below 1000 are: " + sum);
        }
    }
}

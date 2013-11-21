// Project Euler Problem 3
// Solution to: What is the largest prime factor of the number 600851475143?

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prok2ectEulerOne
{
    class EulerThree
    {
        static void Main(string[] args)
        {
            const long EULERNUMBER = 600851475143;
            long largest_factor = 0;
            long[] factors = new long[2];

            for (long i = 2; i * i < EULERNUMBER; i++)
            {
                if (EULERNUMBER % i == 0)
                { 
                    // We found a factor of the given number.
                    factors[0] = i;
                    // Let's find the other factor.
                    factors[1] = EULERNUMBER / i;

                    // Now find if either are prime...
                    for (int j = 0; j < 2; j++)
                    {
                        bool isPrime = true;
                        for (long k = 2; k * k < factors[j]; k++)
                        {
                            if (factors[j] % k == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }

                        // Is this factor larger than the previous?
                        if (isPrime && factors[j] > largest_factor)
                        {
                            largest_factor = factors[j];
                        }
                    }
                }
            }
            Console.Write("The largest prime factor of " + EULERNUMBER + " is: " + largest_factor);
            Console.ReadLine();
        }
    }
}

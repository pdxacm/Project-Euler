// Project Euler Problem #5
// Find the smallest number which divides evenly the numbers 1 through 20.
// BRUTE FORCE APPROACH

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class EulerFive
    {
        static ulong num = 100, answer;
        static bool sol = false;

        static void Main(string[] args)
        {
            while (!sol)
            {
                if (num % 1 == 0 && num % 2 == 0 && num % 3 == 0 && num % 4 == 0 && num % 5 == 0 && num % 6 == 0 && num % 7 == 0 && num % 8 == 0 && num % 9 == 0 && num % 10 == 0
                    && num % 11 == 0 && num % 12 == 0 && num % 13 == 0 && num % 14 == 0 && num % 15 == 0 && num % 16 == 0 && num % 17 == 0 && num % 18 == 0 && num % 19 == 0 && num % 20 == 0)
                {
                    answer = num;
                    sol = true;
                    break;
                }
                num++;
            }
            if (sol == true)
                Console.Write("The answer is: " + answer);
            Console.Read();
        }
    }
}

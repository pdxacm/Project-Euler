using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEulerTwelve
{
    class EulerTwelve
    {
        static int number = 0, i = 1;



        private static int FindNumber(int number)
        {
            int divisors = 0;

            for (int i = 1; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    divisors += 2;
                }
            }

            if (Math.Pow(Math.Sqrt(number), 2) == number)
            {
                divisors--;
            }

            return divisors;
        }
        public static void Main()
        {
            
            while (FindNumber(number) < 500)
            {
                number += i;
                i++;
            }
            Console.Write(number);
            Console.Read();
        }
    }
}

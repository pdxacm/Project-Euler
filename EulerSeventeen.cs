using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerSeventeen
{
    class EulerSeventeen
    {
        // Consider to count { one, two, three, four, five, six, seven, eight, nine }
        // Then {ten, eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen, eighteen, nineteen }
        // Then { twenty-____ for 1-9 }
        // Then { thirty-____ ...}
        // ... All the way to 99 }
        // Then do same for the hundreds...
        static int firstTen = 3 + 3 + 5 + 4 + 4 + 3 + 5 + 5 + 4;
        static int secondTen = 3 + 6 + 6 + 8 + 8 + 7 + 7 + 9 + 8 + 8;
        static int twentyToNinetyNine = (10 * (6 + 6 + 5 + 5 + 5 + 7 + 6 + 6)) + (8 * 36);
        static int hundreds = 36 * 100 + 9 * 854 + 7 * 9 + 9 * 99 * 10;
        static int oneThou = 11;
        public static void Main()
        {
            int total = firstTen + secondTen + twentyToNinetyNine + hundreds + oneThou;
            Console.Write(total);
            Console.Read();
        }
    }
}

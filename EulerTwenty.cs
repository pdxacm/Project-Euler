using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerOne
{
    class EulerTwenty
    {
        // Pulled 100! value from the internet.
        static String num = "93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000";

        static int solution = 0;
        public static void Main()
        {
            for (int i = 0; i < num.Length; i++)
            {
                solution += Convert.ToInt32(num.Substring(i, 1));
            }
            Console.Write("solution is: " + solution);
            Console.Read();
        }
    }
}

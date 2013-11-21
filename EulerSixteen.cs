using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEulerSixteen
{
    class EulerSixteen
    {
        static BigInteger num;
        static String str;
        public static void Main()
        {
            num = (BigInteger)Math.Pow(2, 1000);
            str = Convert.ToString(num);
            num = 0;
            for (int i = 0; i < str.Length; i++)
            {
                num += Convert.ToInt32(str.Substring(i, 1));
            }
            Console.Write(num);
            Console.Read();
        }
    }
}

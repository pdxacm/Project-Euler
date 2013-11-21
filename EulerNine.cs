using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerNine
{
    class Program
    {
        public static void Main()
        {
            int x, y, z;
            for (x = 200; x < 500; x++)
            {
                for (y = 2; y < 500; y++)
                {
                    for (z = 2; z < 500; z++)
                    {
                        if ((x*x) + (y*y) == (z*z) && ((x+y+z) == 1000))
                        {
                            Console.WriteLine("x = " + x + ", y = " + y + ", z = " + z);
                            Console.WriteLine("x + y + z = " + (x + y + z));
                            Console.WriteLine("x * y * z = " + (x * y * z));
                            Console.ReadLine();
                            break;
                        }
                    }
                }
            }
        }
    }
}

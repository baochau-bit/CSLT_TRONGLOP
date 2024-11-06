using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_03
{
    class Program
    {
        static int maxOfThreeNumber(int a, int b, int c)
        {
            int max = 0;

            if (a > b && a > c)
            {
                max = a;
            }
            else if (b > c)
            {
                max = b; // Fixed here
            }
            else
            {
                max = c; // Fixed here
            }

            return max;
        }
    }
}



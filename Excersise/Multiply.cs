using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise
{
    public class Multiply
    {
        public static int Multip(int a, int b)
        {
            if (b < 0)
            {
                return -Multip(a, -b);
            }
            else if (a < 0)
            {
                return -Multip(-a, b);
            }
            else if (b == 0 || a == 0)
            {
                return 0;
            }
            else
            {
                return a + Multip(a, b - 1);
            }
        }
    }
}

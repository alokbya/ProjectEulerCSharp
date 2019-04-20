using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerDotNet
{
    public class Euler5
    {
        public static long smallestMultiple(long maxMultiple)
        {
            bool evenlyDivided = false;
            bool evenRun = false;
            long max = 1;
            while (!evenlyDivided) {
                evenRun = true;
                for (long i = 1; i <= maxMultiple; i++)
                {
                    if (max % i != 0)
                    {
                        evenRun = false;
                        break;
                    }
                }
                if (evenRun)
                {
                    evenlyDivided = true;
                    break;
                }
                max++;
            }
            return max;
        }

    }
}

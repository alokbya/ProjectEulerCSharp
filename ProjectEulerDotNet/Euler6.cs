using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerDotNet
{
    public class Euler6
    {
        public static long SumOfSquares(long limit)
        {
            long sum = 0;
            for (long i = 1; i <= limit; i++)
            {
                sum += (long)Math.Pow(i, 2);            // typecast
            }
            return sum;
        }

        public static long squareOfSum(long limit)
        {
            long sum = 0;
            for (long i = 1; i <= limit; i++)
            {
                sum += i;
            }
            return (long)Math.Pow(sum, 2);          // typecast
        }

        public static void differenceOfsums(long limit)
        {
            Console.WriteLine(String.Format("Square of sums: {0}\r\n" +
                "Sum of Squares: {1}\r\n" +
                "Difference of Sums: {2}",
                squareOfSum(limit),SumOfSquares(limit), squareOfSum(limit) - SumOfSquares(limit)));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerDotNet
{
    public class Euler2
    {
        // here
        public static bool IsEven(uint number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static uint FibonacciNext(uint current, uint last)
        {
            return current + last;
        }

        public static uint FibonacciEvenSum(uint limit)
        {
            uint sum = 0, last = 0;
            for ( uint i = 1; i < limit; i = FibonacciNext(i, last)){
                if (IsEven(i))
                {
                    sum += i;
                    Console.WriteLine(i);
                }
                last = i;

            }
            return sum;
        }
    }


    

}

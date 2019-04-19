using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerDotNet
{
    class EulerMain
    {
        // Run each Euler problem from here
        public static void Main(string[] args)
        {
            //Console.WriteLine(Euler2.FibonacciEvenSum(100));
            Console.WriteLine("Problem 3... ");
            Euler3.printPrimeFactors(600851475143);
            Console.ReadLine();
        }
    }
}

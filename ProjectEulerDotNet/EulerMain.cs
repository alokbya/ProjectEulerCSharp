using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerDotNet
{
    class EulerMain
    {
        public static void Main(string[] args)
        {
            int limit = 1000;
            Console.WriteLine(
                String.Format(
                "Limit: {0} \r\nSum: {1}",
                limit,
                Euler1.SumOfMultiplesOf_3and5(limit)
                ));

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerDotNet
{
    public class Euler4
    {
        public static bool isPalindrome(long number)
        {
            string sl = number.ToString();
            string rsl = Reverse(sl);
            if(sl == rsl)
            {
                return true;
            }
            return false;
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static long palindromeProduct(bool print=true, int digits=2)
        {
            long max = 0;
            long upperlimit = (long)Math.Pow(10, digits);
            for (long i = 0; i < upperlimit; i++)
            {
                for (long j = 0; j < upperlimit; j++)
                {
                    if (isPalindrome(i * j) && (i*j) > max)
                    {
                        if (print)
                        {
                            Console.WriteLine(i * j);
                        }
                        max = i * j;
                    }
                }
            }
            return max;
        }
    }   

}

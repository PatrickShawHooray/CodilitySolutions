using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySolutions
{
    public static class CountFactors
    {
        public static int solution(int N)
        {
            if (N == 1)
                return 1;

            int ret = 0;
            int i = 1;

            // search up to sqrt; +2 for each find of modulus 0
            int sqrt = (int)Math.Sqrt(N); 
            while(i <= sqrt)
            {
                if (N % i == 0)
                    ret += 2;
                i++;
            }

            // check for perfect square (one to many if that's true)
            if (sqrt * sqrt == N)
                ret--;

            return ret;
        }
    }
}

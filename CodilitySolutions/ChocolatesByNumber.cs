using System;
using System.Collections.Generic;

namespace CodilitySolutions
{
    static public class ChocolatesByNumber
    {
        static public int solution(int N, int M)
        {
            // test for min vals
            if (N == 1)
                return 1;

            if (M == 1)
                return N;

            // find GCD pair (greatest common denom)
            int f = N;
            int s = M;

            while(f != s)
            {
                if (f > s)
                    f = f - s;
                else
                    s = s - f;
            }

            // return the actual GCD (by using its pair found above)
            return N / f;
        }
    }
}

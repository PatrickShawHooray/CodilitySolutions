using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySolutions
{
    static public class CountDiv
    {
        public static int solution(int A, int B, int K)
        {
            int ret = 0;

            for(int i = A; i <= B; i++)
            {
                if (i % K == 0)
                    ret++;
            }

            return ret;
        }
    }

    static public class CountDiv2
    {
        public static int solution(int A, int B, int K)
        {
            int ret = 0;
            if (A % K == 0)
                ret++;

            ret += (B / K) - (A / K);

            return ret;
        }
    }
}

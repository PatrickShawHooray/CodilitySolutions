using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySolutions
{
    static public class MaxSliceSum
    {
        static public int solution(int[] A)
        {
            if (A.Length == 1)
                return A[0];

            int high = A[0];
            int runT = A[0];

            // keep running total in runT
            // if any A[i] is > runT; restart runT at A[i]
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > A[i] + runT)
                    runT = A[i];
                else
                    runT += A[i];

                if (runT > high)
                    high = runT;
            }

            return high;
        }
    }
}

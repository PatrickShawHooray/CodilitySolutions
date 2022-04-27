using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodilitySolutions
{
    static public class MaxProfit
    {
        static public int solution(int[] A)
        {
            if (A.Length < 1)
                return 0;

            int bestProfit = 0;
            var accumulator = 0;

            // accumulator is a running sum that resets to 0 when it drops below 0
            for (int i = 1; i < A.Length; i++)
            {
                accumulator += A[i] - A[i - 1];

                if (accumulator < 0)
                {
                    accumulator = 0;
                }

                if (accumulator > bestProfit)
                    bestProfit = accumulator;
            }

            return bestProfit;
        }
    }
}

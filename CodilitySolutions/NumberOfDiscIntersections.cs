using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySolutions
{
    public static class NumberOfDiscIntersections
    {
        public static int solution(int[] A)
        {
            long sum = 0;
            
            // get the ranges of each position on A
            long[] high = new long[A.Length];
            long[] low = new long[A.Length];

            for (long i = 0; i < A.Length; i++)
            {
                high[i] = i + (long)A[i];
                low[i] = i - (long)A[i];
            }

            //sort the ranges to iterate over .. was off by a few numbers each time
            // until I tried sorting
            Array.Sort(high);
            Array.Sort(low);

            // tetsting point
            long t = 0;

            // iterate over original array once while moving a testing point along it as well
            // add t and remove a while a's high is equal or greater than t's low
            for (int a = 0; a < A.Length; a++)
            {
                while (t < A.Length && high[a] >= low[t])
                {
                    sum = sum + t;
                    sum = sum - a;
                    t++;
                }
            }

            if (sum > 10000000)
                return -1;

            return (int)sum;
        }
    }
}

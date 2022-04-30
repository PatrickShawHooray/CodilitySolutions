using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySolutions
{
    static public class MaxDoubleSliceSum
    {
        static public int solution(int[] A)
        {
            if (A.Length < 4)
                return 0;

            int[] highRev = new int[A.Length];
            int[] highFwd = new int[A.Length];
            int sumTrack = 0;
            int max = 0;

            // get running total of values from end to start
            for (int i = A.Length - 2; i > 0; i--)
            {
                sumTrack = Math.Max(0, A[i] + sumTrack);
                highRev[i] = sumTrack;
            }

            // reset sum track 
            sumTrack = 0;

            // get running total of values from start to end
            for (int i =  1; i < A.Length - 1; i++)
            {
                sumTrack = Math.Max(0, A[i] + sumTrack);
                highFwd[i] = sumTrack;
            }

            // find the highest start + end combo
            for(int i = 0; i < A.Length - 2; i++)
            {
                max = Math.Max(max, highFwd[i] + highRev[i + 2]);
            }

            return max;
        }
    }
}

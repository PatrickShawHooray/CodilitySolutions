using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodilitySolutions
{
    static public class MinAvgTwoSlice
    {
        static public int solution(int[] A)
        {
            if (A.Length < 2)
                return -1;

            int pos = 0;
            double low = (A[0] + A[1]) / 2.0;

            // slice has at least 2 elements
            for (int i = 0; i + 1 < A.Length; i++)
            {
                double thisLow = (A[i] + A[i + 1]) / 2.0;
                
                // check if adjacent elements exists and is is lower
                if (i + 2 < A.Length)
                {
                    double three = (A[i] + A[i + 1] + A[i + 2]) / 3.0;
                    thisLow = three < thisLow ? three : thisLow;
                }

                if (thisLow < low)
                {
                    low = thisLow;
                    pos = i;
                }
            }

            return pos;
        }
    }
}

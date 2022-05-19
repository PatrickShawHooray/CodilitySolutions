using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySolutions
{
    static public class Peaks
    {
        static public int solution(int[] A)
        {
            List<int> peaks = new List<int>();
            for (var i = 1; i < A.Length - 1; i++)
            {
                if (A[i - 1] < A[i] && A[i] > A[i + 1])
                    peaks.Add(i);
            }

            if (peaks.Count < 1)
                return 0;

            if (peaks.Count == 1)
                return 1;

            // By segment size (starting with largest possible)
            for (int i = A.Length; i >= 1; i--)
            {
                // make sure it's a prime
                if (A.Length % i == 0)
                { 
                    // get segment 
                    int segment = A.Length / i;

                    // count segments where a peak was found
                    int segWithPeak = 0;

                    foreach (int p in peaks)
                    {
                        // check the segment has a peak
                        if (p / segment == segWithPeak)
                        { 
                            segWithPeak++; 
                        }
                    }
                    
                    // validate that every segment had a peak
                    if (segWithPeak == i)
                    {
                        return i;
                    }
                }
            }

            return 0;
        }
    }
}
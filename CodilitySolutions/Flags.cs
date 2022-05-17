using System;
using System.Collections.Generic;

namespace CodilitySolutions
{
    static public class Flags
    {
        static public int solution(int[] A)
        {
            List<int> peaks = new List<int>();
            for (var i = 1; i < A.Length - 1; i++)
            {
                if (A[i - 1] < A[i] && A[i] > A[i + 1])
                    peaks.Add(i);
            }


            if (peaks.Count < 2)
                return peaks.Count;

            // use the sqrt + 1 as largest pssoible flag count
            int sqrt = (int)Math.Floor(Math.Sqrt(peaks[peaks.Count - 1] - peaks[0]));

            // start with most possible flags - test against amount actually found against it
            for (int i = sqrt + 1; i > 0; i--)
            {
                int thisCount = 1;
                int storedDist = 0;
                
                for (var j = 0; j < peaks.Count - 1; j++)
                {
                    int thisPeak = peaks[j];
                    int nextPeak = peaks[j + 1];
                    int thisPeakDist = Math.Abs(nextPeak - thisPeak);

                    if ((thisPeakDist + storedDist) >= i)
                    {
                        thisCount++;
                        storedDist = 0;
                    }
                    else
                    {
                        storedDist += thisPeakDist;
                    }

                    // check for match .. did the tried amount of flags match the reality
                    if (thisCount == i)
                        return thisCount;
                } 
            }

            return 0;
        }
    }
}

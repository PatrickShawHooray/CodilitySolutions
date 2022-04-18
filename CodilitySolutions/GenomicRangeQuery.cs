using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodilitySolutions
{
    static public class GenomicRangeQuery
    {
        static public int[] solution(string S, int[] P, int[] Q)
        {
            // this one was tricky for performance ... finding a workable solution was simple
            // but getting one that met 100% performance took some time to sort out.
            // We do NOT want to iterate over the same letters again and again, so, in order
            // to do that once I implemented a 'prefix sum' solution where we count the number
            // of A, C, G in the string by position and store that in arrays that we can
            // reference to check the sum of a letter by two different positions on the string. 

            if (P.Length != Q.Length || S.Length < 1)
                return new int[0];

            // additional element tacked to end to help test for when there is a single character in S
            int[] As = new int[S.Length + 1];
            int[] Cs = new int[S.Length + 1];
            int[] Gs = new int[S.Length + 1];
            int[] ret = new int[P.Length];
            int sumA = 0;
            int sumC = 0;
            int sumG = 0;

            // create arrays for prefix sums for A, C and G
            for (int k = 0; k < S.Length; k++)
            {
                char c = S[k];

                if (c == 'A')
                    sumA++;
                else if (c == 'C')
                    sumC++;
                else if (c == 'G')
                    sumG++;

                As[k + 1] = sumA;
                Cs[k + 1] = sumC;
                Gs[k + 1] = sumG;
            }

            for (int i = 0; i < P.Length; i++)
            {
               
                if (As[Q[i] + 1] - As[P[i]] > 0)
                    ret[i] = 1;
                else if (Cs[Q[i] + 1] - Cs[P[i]] > 0)
                    ret[i] = 2;
                else if (Gs[Q[i] + 1] - Gs[P[i]] > 0)
                    ret[i] = 3;
                else
                    ret[i] = 4; // only T
            }

            return ret;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodilitySolutions
{
    static public class MissingInteger
    {
        static public int solution(int[] A)
        {
            // check for empty array
            if (A.Length < 1)
                return 1;

            // sort and distinct the array
            Array.Sort(A);
            A = A.Distinct().ToArray();

            // find the index of 1
            int oneInd = Array.IndexOf(A, 1);
            if (oneInd == -1)
                return 1;

            // from index of 1, check that each integer is present
            for (int i = oneInd; i < A.Length; i++)
            {
                if (A[i] != i - oneInd + 1)
                    return i - oneInd + 1;
            }

            // no gaps in array .. get largest and add one
            return A[A.Length - 1] + 1;
        }
    }
}

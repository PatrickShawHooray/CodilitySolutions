using System;

namespace CodilitySolutions
{
    static public class MaxProductOfThree
    {
        static public int solution(int[] A)
        {
            if (A.Length < 3)
                return 0;

            // sort
            Array.Sort(A);

            //[3 largest numbers]
            int p = A[A.Length - 3] * A[A.Length - 2] * A[A.Length - 1];
            // [2 smallest(negatives) and largest]
            int n = A[0] * A[1] * A[A.Length - 1];

            return p > n ? p : n;
        }
    }
}

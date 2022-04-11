using System;

namespace CodilitySolutions
{
    static public class Triangle
    {
        public static int solution(int[] A)
        {
            if (A.Length < 2)
                return 0;
  
            // p + q > r   
            // q + r > p   
            // r + p > q     

            // sort
            Array.Sort(A);

            // long in case ints are large
            long p, q, r;

            // try 3 in a row until a match is found
            for (int i = 2; i < A.Length; i++)
            {
                p = A[i - 2];
                q = A[i - 1];
                r = A[i];
                if (p + q > r && q + r > p && r + p > q)
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}

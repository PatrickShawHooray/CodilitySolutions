using System;
using System.Linq;

namespace CodilitySolutions
{
    static public class PermMissingElem
    {
        private static int solution(int[] A)
        {
            // sort
            Array.Sort(A);

            // empty_and_single
            if (A.Length == 0)
                return 1;

            if (A[0] != 1)
            {
                return 1;
            }

            if (A.Length == 1)
                return A[0] + 1;

            int check = 0;
            int n = 0;

            while (A.Length > 10)
            {
                n = A[0];
                check = A.Length / 2;

                // check subset
                if (n + check != A[check])
                {
                    A = A.Take(check).ToArray();
                }
                else
                {
                    A = A.Skip(check - 1).ToArray();
                }
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (i + 1 > A.Length - 1)
                    return A[i] + 1;
                else
                {
                    if (A[i] + 1 != A[i + 1])
                        return A[i] + 1;
                }

            }

            return 0;
        }
    }
}

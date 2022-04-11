using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodilitySolutions
{
    static public class PermCheck
    {
        public static int solution(int[] A)
        {
            if (A.Length == 0)
                return 1;

            if (A.Length == 1 && A[0] != 1)
                return 0;

            // use hashset to check for missing element via the length of the array
            HashSet<int> toFind = new HashSet<int>();
            for(int i = 0; i < A.Length; i++)
            {
                toFind.Add(A[i]);
            }

            // check if number in range is missing from toFind
            for (int i = 1; i <= A.Length; i++)
            {
                if (!toFind.Contains(i))
                    return 0;
            }

            return 1;
        }
    }
}

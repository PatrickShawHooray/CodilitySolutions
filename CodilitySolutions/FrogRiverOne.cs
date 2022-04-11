using System.Collections.Generic;

namespace CodilitySolutions
{
    static public class FrogRiverOne
    {
        static public int solution(int X, int[] A)
        {
            // create a hashset of ints from 1 to X
            // remove number from hashset where found in X over loop
            // once hashset is empty return i
            HashSet<int> needsLeaf = new HashSet<int>();

            for(int r = 1; r <= X; r++)
            {
                needsLeaf.Add(r);
            }

            for (int i = 0; i < A.Length; i++)
            {
                needsLeaf.Remove(A[i]);
                if (needsLeaf.Count == 0)
                    return i;
            }

            return -1;
        }
    }
}

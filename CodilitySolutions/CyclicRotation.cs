using System.Collections.Generic;

namespace CodilitySolutions
{
    static public class CyclicRotation
    {
        public static int[] solution(int[] A, int K)
        {
            if (A.Length == 0)
                return A;

            List<int> L = new List<int>();
            L.AddRange(A);
            while (K > 0)
            {
                int o = L[L.Count - 1];
                L.RemoveAt(L.Count - 1);
                L.Insert(0, o);
                K--;
            }

            return L.ToArray();
        }
    }
}

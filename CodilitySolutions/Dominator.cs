using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodilitySolutions
{
    static public class Dominator
    {
        static public int solution(int[] A)
        {
            if (A.Length < 1)
                return -1;

            // key = number found at A[i]; value = running count of times the key has been found
            Dictionary<int, int> kounter = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (kounter.ContainsKey(A[i]))
                    kounter[A[i]]++;
                else
                    kounter.Add(A[i], 1);
            }

            // which key (A[i]) occurs the most often
            int largestCount = kounter.Values.Max();

            // check if there IS a dominator
            if (kounter.Values.Max() > A.Length / 2)
            {
                // retrieve the key ... which is the number that appeared most often
                int v = kounter.FirstOrDefault(k => k.Value == largestCount).Key;

                // return the first index of the number that appeared most often 
                return Array.IndexOf(A, v);
            }
            else
            {
                return -1;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodilitySolutions
{
    static public class EquiLeader
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

            // which key (A[i]) occurs the most often is the leader
            int totalLeaders = kounter.Values.Max();
            int leader = kounter.FirstOrDefault(k => k.Value == totalLeaders).Key;

            int leadersLeftHalf = 0;
            int leadersRightHalf = 0;
            int arrLength = A.Length;
            int equiLeaders = 0;

            // iterate array again and check by counting leaders by left and right side of index
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == leader)
                    leadersLeftHalf++;

                leadersRightHalf = totalLeaders - leadersLeftHalf;

                if(leadersLeftHalf > (i + 1) / 2 && leadersRightHalf > (arrLength - i - 1) / 2)
                {
                    equiLeaders++;
                }
            }

            return equiLeaders;
        }
    }
}

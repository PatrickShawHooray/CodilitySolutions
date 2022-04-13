using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodilitySolutions
{
    static public class MaxCounters
    {
        public static int[] solution(int N, int[] A)
        {
            int[] counters = new int[N];
            int max = 0;
            int floor = 0;

            for (int i = 0; i < A.Length; i++)
            {
                int v = A[i];
                if (v <= N)
                { 
                    // make sure it's at least at the floor value
                    if (counters[v - 1] < floor)
                        counters[v - 1] = floor; 

                    counters[v - 1]++;  

                    // check if increased value is new max
                    if (counters[v - 1] > max)
                    { 
                        max = counters[v - 1];
                    }
                }
                else if (A[i] == N + 1)
                {      
                    // establish new floor
                    floor = max;
                }
            }

            // make sure every value is at least at the floor
            for (int k = 0; k < counters.Length; k++)
            {
                if (counters[k] < floor)
                    counters[k] = floor;
            }

            return counters;
        }
    }
}

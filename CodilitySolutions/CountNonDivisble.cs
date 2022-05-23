using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySolutions
{
    static public class CountNonDivisble
    {
        static public int[] solution(int[] A)
        {
            int[] ret = new int[A.Length];
            Dictionary<int, int> countNums = new Dictionary<int, int>();

            // count the number of occurances of each value
            for (int i = 0; i < A.Length; ++i)
            {
                if(countNums.ContainsKey(A[i]))
                {
                    countNums[A[i]] += 1;
                }
                else
                {
                    countNums.Add(A[i], 1);
                }
            }

            for (int i = 0; i < A.Length; ++i)
            {
                int divisors = 0;
                int sqrt = (int)Math.Sqrt(A[i]);

                // limit check up to sqrt for efficiency 
                for(int j = 1; j <= sqrt; j++)
                {
                    // check if j is a divisor
                    if (A[i] % j == 0)
                    {
                        // check if j is actually in the array
                        if (countNums.ContainsKey(j))
                        {
                            divisors += countNums[j];
                        }

                        // get the other divisor and check if it (k) is actually in the array
                        int k = A[i] / j;
                        if(k != j && countNums.ContainsKey(k))
                        {
                            divisors += countNums[k];
                        }
                    }
                }

                ret[i] = A.Length - divisors;
            }

            return ret;
        }
    }
}

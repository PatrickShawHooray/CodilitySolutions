using System;
using System.Linq;

namespace CodilitySolutions
{
    static public class TapeEquilibrium
    {
        public static int solution(int[] A)
        {
            // get the full sum for math in loop
            int arrSum = A.Sum();
            
            // additional varialbes for the loop
            int lowest = int.MaxValue;
            int first = 0;
            int second = 0;
            int diff;

            // loop array and compare halves - retain lowest differential of the 2 halves
            for(int i = 1; i < A.Length; i++)
            {
                first = first + A[i - 1];
                second = arrSum - first;
                diff = Math.Abs(first - second);
                if (diff < lowest)
                    lowest = diff;
            }

            return lowest;
        }
    }
}

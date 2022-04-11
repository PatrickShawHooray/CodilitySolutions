using System.Linq;

namespace CodilitySolutions
{
    static public class CountCars
    {
        public static int Solution(int[] A)
        {
            if (A.Length < 2)
                return 0;

            int sum = 0;
            int ones = A.Sum();

            // sum 1s and copy to countOnes
            // add sum + countOnes when 0 ... reduce countOnes on 1
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                    sum += ones;
                else
                    ones--;
            }

            return sum <= 1000000000 ? sum : -1;
        }
    }
}

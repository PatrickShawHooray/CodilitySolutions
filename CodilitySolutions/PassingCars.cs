using System.Linq;

namespace CodilitySolutions
{
    static public class PassingCars
    {
        public static int Solution(int[] A)
        {
            // if only one car, they never pass another car
            if (A.Length < 2)
                return 0;

            int ret = 0;

            // sum all the ones
            int ones = A.Sum();

            // add sum to return when 0 ... reduce ones when 1
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                    ret += ones;
                else
                    ones--;
            }

            return ret > -1 && ret <= 1000000000 ? ret : -1;
        }
    }
}
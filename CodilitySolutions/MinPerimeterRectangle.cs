using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySolutions
{
    static public class MinPerimeterRectangle
    {
        // least difference between height and width is what we are after
        // 2 factors closest to sqrt will give us that

        static public int solution(int N)
        {
            int sqrt = (int)Math.Sqrt(N);

            // check for square
            if (sqrt * sqrt == N)
                return sqrt * 4;

            int i = sqrt;
            int h = 0;
            int w = 0;

            // find largest factor starting at square root
            while (i >= 1 && h == 0)
            {
                if (N % i == 0)
                {
                    h = i;
                    w = N / h;
                }
                i--;
            }

            // for values where the only factors are 1 and thhe number
            if(h == 0 || w == 0)
            {
                h = 1;
                w = N;
            }

            return (h * 2) + (w * 2);
        }
    }
}

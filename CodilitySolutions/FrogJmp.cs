namespace CodilitySolutions
{
    static public class FrogJmp
    {
        public static int solution(int X, int Y, int D)
        {
            if (X >= Y || D <= 0)
                return 0;

            int jumps = (Y - X) / D;
            X += (D * jumps);
            if (Y > X)
                jumps++;

            return jumps;
        }
    }
}

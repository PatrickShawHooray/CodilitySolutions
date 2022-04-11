namespace CodilitySolutions
{
    static public class OddOccurencesInArray 
    {
        static public int solution(int[] A)
        { 
            if(A.Length == 0)
                return 0;

            // XOR ^ will remove any number stored in ret
            // so whatever remains in ret is the answer
            int ret = A[0];
            for(int i = 1; i<A.Length; i++)
            {
                ret = ret ^ A[i];
            }

            return ret;
        }
    }
}
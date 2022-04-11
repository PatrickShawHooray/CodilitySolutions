using System.Linq;

namespace CodilitySolutions
{
    static public class Distinct
    {
        static public int solution(int[] A)
        {
            int[] distincts = A.Distinct().ToArray();
            return distincts.Length;
        }
    }
}

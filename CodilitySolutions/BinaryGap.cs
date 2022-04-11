using System;

namespace CodilitySolutions
{
    static public class BinaryGap
    {
        static public int solution(int N)
        {
            int ret = 0;

            // convert number to binary string
            string b = Convert.ToString(N, 2);

            // look for first and second index of 1
            int first = b.IndexOf('1');
            int second = b.IndexOf('1', b.IndexOf('1') + 1);

            // while second index of 1 exists, make substring and compare length
            while (second != -1)
            {
                string zStr = b.Substring(first + 1, second - first - 1);
                if (zStr.Length > ret)
                    ret = zStr.Length;

                // remove section of string tested
                b = b.Remove(first, second - first);
                first = b.IndexOf('1');
                second = b.IndexOf('1', b.IndexOf('1') + 1);
            }

            return ret;
        }
    }
}
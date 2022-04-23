using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySolutions
{
    static public class Nesting
    {
        static public int solution(string S)
        {
            // if uneven its false
            if (S.Length % 2 != 0)
                return 0;

            int open = 0;
            for(int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                    open++;
                else
                {
                    // make sure there is always an open bracket already when closed is found
                    if (open == 0)
                        return 0;

                    open--;
                }   
            }

            // there can be no left over open brackets
            return open == 0 ? 1 : 0;
        }
    }
}

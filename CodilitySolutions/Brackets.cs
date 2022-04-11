using System.Collections.Generic;

namespace CodilitySolutions
{
    static public class Brackets
    {
        public static int solution(string S)
        {
            if (S.Length == 0)
                return 1;

            Stack<char> oppStack = new Stack<char>();
            // create a stack of opposing chars to test against
            for (int i = 0; i < S.Length; i++)
            {
                switch (S[i])
                {
                    case '{':
                        oppStack.Push('}');
                        break;
                    case '[':
                        oppStack.Push(']');
                        break;
                    case '(':
                        oppStack.Push(')');
                        break;
                    default:
                        if (oppStack.Count == 0)
                        {
                            return 0;
                        }
                        else
                        {
                            char popped = oppStack.Pop();
                            if (popped != S[i])
                            { // not a pair
                                return 0;
                            }
                            break;
                        }
                }
            }

            // stack should be empty now
            if (oppStack.Count > 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}

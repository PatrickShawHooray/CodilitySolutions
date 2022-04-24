using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySolutions
{
    static public class StoneWall
    {
        static public int solution(int[] H)
        {
            if (H.Length < 1)
                return 0;

            // count first brick and add to stack
            int bricks = 1;
            Stack<int> S = new Stack<int>();
            S.Push(H[0]);

            for (int i = 1; i < H.Length; i++)
            {
                if (H[i] != S.Peek())
                {
                    if(H[i] > S.Peek())
                    {
                        S.Push(H[i]);
                        bricks++;
                    }
                    else
                    {
                        bool foundLevel = false;

                        while (S.Count > 0 && foundLevel == false)
                        {
                            if (H[i] == S.Peek())
                            {
                                foundLevel = true;
                            }
                            else if(H[i] > S.Peek())
                            {
                                S.Push(H[i]);
                                bricks++;
                                foundLevel = true;
                            }
                            else
                            {
                                // H[i] is lower
                                S.Pop();
                                if(S.Count == 0)
                                {
                                    bricks++;
                                    foundLevel = true;
                                    S.Push(H[i]);
                                }
                            }
                        }
                    }
                }
            }

            return bricks;
        }
    }
}

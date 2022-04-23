using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodilitySolutions
{
    static public class Fish
    {
        static public int solution(int[] A, int[] B)
        {
            Stack<int> zeroes = new Stack<int>();
            Stack<int> ones = new Stack<int>();
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == 0)
                {
                    // check if there are 1s it must swim against
                    if (ones.Count == 0)
                        zeroes.Push(A[i]);
                    else
                    {
                        while (ones.Count > 0)
                        {
                            if (ones.Peek() > A[i])
                            {
                                break;
                            }
                            else
                            {
                                ones.Pop();
                            }
                        }

                        // 0 got through the 1s
                        if(ones.Count == 0)
                        {
                            zeroes.Push(A[i]);
                        }
                    }
                }
                else
                {
                    ones.Push(A[i]);
                }
            }

            return zeroes.Count + ones.Count;
        }
    }
}

﻿using System;
using System.Linq;

namespace RunColditilyExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // some larger test cases
            int[] thousand = Enumerable.Range(1, 1000).ToArray();
            int[] thousandNoThirteen = thousand.Where(e => e != 13).ToArray();
            int[] tenThousand = Enumerable.Range(1, 10000).ToArray();
            int[] thousandStartNeg500 = Enumerable.Range(-500, 1000).ToArray();

            Console.WriteLine(CodilitySolutions.Fish.solution(new int[] { 4,3,2,1,5 }, new int[] { 0, 1, 0, 0, 0 }));
        }
    }
}
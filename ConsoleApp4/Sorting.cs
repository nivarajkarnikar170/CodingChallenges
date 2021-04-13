using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Sorting
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                // add all the elements to the HashSet
                hs.Add(A[i]);
            }

            // return the size of hashset as
            // it consists of all Unique elements
            return hs.Count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class BinaryGap
    {
        public int longestBinGapSplitMethod(int N) 
        {
            string binary = Convert.ToString(N, 2);
            binary = binary.TrimEnd(new Char[] { '0' });
            var gaps = binary.Split('1');
            int max = 0;
            foreach (var item in gaps)
            {
                if (!string.IsNullOrEmpty(item))
                    if (item.Length > max)
                        max = item.Length;
            }
            return max;
        }


        /* A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.

        For example, number 9 has binary representation 1001 and contains a binary gap of length 2. The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. The number 20 has binary representation 10100 and contains one binary gap of length 1. The number 15 has binary representation 1111 and has no binary gaps. The number 32 has binary representation 100000 and has no binary gaps.

        Write a function:

        class Solution { public int solution(int N); }

        that, given a positive integer N, returns the length of its longest binary gap. The function should return 0 if N doesn't contain a binary gap.

        For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 and so its longest binary gap is of length 5. Given N = 32 the function should return 0, because N has binary representation '100000' and thus no binary gaps.

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [1..2,147,483,647].*/


        public int LongestBinaryGap(int num) 
        {
            var bin = Convert.ToString(num, 2);
            var binCharArray = bin.ToCharArray();
            bool startCount = false;
            int count = 0;
            int maxCount = 0;
            for (int i = 0; i < binCharArray.Length; i++)
            {

                if (startCount) {
                    if (binCharArray[i] == '0') {
                        count++;
                    }
                    else 
                    {
                        if (count > 0 && maxCount < count) 
                        {
                            maxCount = count;
                        }
                        count = 0;
                        startCount = false;
                    }
                }
               
                if (binCharArray[i] == '1') 
                {
                    startCount = true;
                }
            }

            return maxCount;
        }

        public void PrintInvertedTriangle() 
        {
            int rows = 4;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < r; c++)
                {
                    Console.Write(" ");
                }

                for (int c = 0; c <= (rows * 2 - 2) - (2 * r); c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public int MinPositiveIntegerNotInTheArray(int[] A)
        {
            int N = A.Length;
            HashSet<int> set = new HashSet<int>();
            foreach (int a in A)
            {
                if (a > 0)
                {
                    set.Add(a);
                }
            }
            for (int i = 1; i <= N + 1; i++)
            {
                if (!set.Contains(i))
                {
                    return i;
                }
            }
            return 1;
        }
    }
}

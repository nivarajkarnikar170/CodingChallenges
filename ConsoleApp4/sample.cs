using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class sample
    {

        public static void GetSine(string s)
        {

            char[] str = s.ToCharArray();

            int count = 1;

            int count1 = 1;

            int count2 = 2;

            int counter = 1;

            for (int i = 0; i < str.Length; i++)
            {

                if (counter == count2)
                {

                    Console.Write((str[i]));

                    str[i] = ' ';

                    count2 = count2 + 4;

                }

                else
                {

                    Console.Write(" ");

                }

                counter++;

            }

            Console.WriteLine("");

            for (int i = 0; i < str.Length; i++)
            {

                if (count % 2 != 0)
                {

                    Console.Write(str[i]);

                }

                else
                {

                    Console.Write(" ");

                }

                count++;

            }

            Console.WriteLine("");

            for (int i = 0; i < str.Length; i++)
            {

                if (count1 % 2 == 0 && str[i] != ' ')
                {

                    Console.Write(str[i]);

                }

                else
                {

                    Console.Write(" ");

                }

                count1++;

            }
        }

        public static void GetSineWave(string s)
        {
            var arr = s.ToCharArray();

            var counterFirst = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == counterFirst)
                {
                    Console.Write(arr[i]);
                    counterFirst += 4;
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(arr[i]);
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();

            var counterThird = 3;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == counterThird)
                {
                    Console.Write(arr[i]);
                    counterThird += 4;
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }

        public static void ReverseWords() 
        {
            var inp = "What is your name?";
            var arr = inp.Split(" ");

            StringBuilder sb = new StringBuilder();
            for (int i = arr.Length - 1; i >= 0; i--) 
            {                
                sb.Append(arr[i]);
                if(i > 0)
                    sb.Append(" ");
            }

            Console.WriteLine(sb.ToString());
        }

        //binary tree longest branch
        public static string Solution(long[] arr)
        {
            // Type your solution here
            if (arr == null || arr.Length == 0) return "";
            long leftSum = 0;
            long rightSum = 0;

            int left = 1;
            int right = 2;

            leftSum = getTreeSum(arr, left);
            rightSum = getTreeSum(arr, right);

            if (leftSum > rightSum) return "Left";
            else if (leftSum < rightSum) return "Right";
            return "";
        }

        public static long getTreeSum(long[] arr, int i)
        {
            if (i > arr.Length - 1 || arr[i] == -1) return 0;
            int leftChild = 2 * i + 1;
            int rightChild = 2 * i + 2;
            long sum = 0;
            if (i < arr.Length)
            {
                sum = arr[i] + getTreeSum(arr, leftChild) + getTreeSum(arr, rightChild);
            }
            return sum;
        }
    }
}

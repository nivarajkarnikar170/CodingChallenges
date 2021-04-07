using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //var obj = new BinaryGap();
            //obj.LongestBinaryGap(32);
            //obj.longestBinGapSplitMethod(529);
            var arrayObj = new ArraysManipu();
            //var arrayResult = arrayObj.CyclicRotation(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 14);
            //var r = arrayObj.oddOccurance(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            //var complexities = new Complexities();
            //complexities.MinDifferenceTape(new int[] { 3, 1, 2, 4, 3 });
            //var counting = new Counting();
            //counting.EarliestRiverCrossingTime(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 });
            //counting.isArrayPerm(new int[] { 1 });
            //counting.MaxCounters(5, new int[] { 3, 4, 4, 6, 1, 4, 4 });
            // counting.smallestPositiveInt(new int[] { 1, 2, 3});
            //sample.GetSineWave("HelloWorldHowAreYou");
            //sample.ReverseWords();
            //AgreeyaCodility.solution(2014, "April", "May", "Wednesday");


            BinTree t2 = new BinTree();
            int[] arr = { 1, 2, 3, 4, 5, 6, 6, 6, 6 };
            t2.root = t2.insertLevelOrder(arr, t2.root, 0);
            t2.inOrder(t2.root);

        }
    }
}

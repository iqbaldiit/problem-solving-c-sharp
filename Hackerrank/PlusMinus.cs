using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.Hackerrank
{
    public static class PlusMinus
    {
        public static void plusMinus(List<int> arr)
        {
            var n=arr.Count;
            var negative = 0;
            var positive = 0;
            var zeros = 0;

            //// Approach 1
            //for (int i = 0; i < arr.Count; i++) {
            //    if (arr[i] == 0) { zeros++; }
            //    if (arr[i] > 0) {positive++; }
            //    if (arr[i] <0) { negative++; }
            //}

            //approach 2 using LINQ
            negative = arr.Count(x=>x<0);
            positive=arr.Count(x=>x>0);
            zeros=arr.Count(x=>x==0);

            Console.WriteLine("Positive Ratios: {0}", (decimal)positive / n);
            Console.WriteLine("Negetive Ratios: {0}", (decimal)negative / n);
            Console.WriteLine("Zero Ratios: {0}", (decimal)zeros / n);
        }

        public static void Execute()
        {
            List<int> arr = [1, 1, 0, -1, -2];
            plusMinus(arr);
        }
    }
}

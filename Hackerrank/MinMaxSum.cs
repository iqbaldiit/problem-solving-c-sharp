using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.Hackerrank
{
    //Source: https://www.hackerrank.com/challenges/mini-max-sum/problem?isFullScreen=true
    public class MinnMaxSum
    {
        public static void mininMaxSum(List<int> arr)
        {
            // Convert each element to long to handle large numbers
            List<long> longArr = arr.Select(x => (long)x).ToList();

            // Calculate total sum once
            long totalSum = longArr.Sum();

            // Initialize min and max sum to first possible sum (totalSum - first element)
            long minSum = totalSum - longArr[0];
            long nMaxSum = minSum;

            // Check each possible sum by removing one number at a time
            for (int i = 1; i < longArr.Count; i++)
            {
                long nCurrentSum = totalSum - longArr[i];
                minSum = Math.Min(minSum, nCurrentSum);
                nMaxSum = Math.Max(nMaxSum, nCurrentSum);
            }

            Console.WriteLine($"{minSum} {nMaxSum}");

        }

        public static void Execute()
        {            
            List<int> arr = [9, 3, 5,7,1];
            mininMaxSum(arr);
        }
    }
}

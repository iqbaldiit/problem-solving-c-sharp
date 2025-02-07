using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.SlidingWindow
{
    /*
        You are given an integer array nums consisting of n elements, 
        and an integer k.
        Find a contiguous subarray whose length is equal to k 
        that has the maximum average value and return this value. 
        Any answer with a calculation error less than 10-5 will 
        be accepted. 

        Example 1:
        Input: nums = [1,12,-5,-6,50,3], k = 4
        Output: 12.75000
        Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75
        
        Example 2:
        Input: nums = [5], k = 1
        Output: 5.00000

        Constraints:
        n == nums.length
        1 <= k <= n <= 105
        -104 <= nums[i] <= 104     
     */
    public static class MaximumAverageSubarrayI
    {
        static double FindMaxAverage(int[] nums, int k)
        {
            // Compute the sum of the first k elements
            double nMaxSum = nums.Take(k).Sum();
            double nCurrentSum = nMaxSum;

            // Use a sliding window to compute the sum of subsequent subarrays
            for (int i = k; i < nums.Length; i++)
            {
                nCurrentSum += nums[i] - nums[i - k];
                nMaxSum = Math.Max(nMaxSum, nCurrentSum);
            }

            // Compute the maximum average
            return nMaxSum/k;
        }

        public static void Execute()
        {
            Console.WriteLine(FindMaxAverage([1, 12, -5, -6, 50, 3], 4));
            Console.WriteLine(FindMaxAverage([5],1));
        }
    }
}

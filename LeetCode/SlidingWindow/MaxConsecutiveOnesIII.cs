using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.SlidingWindow
{
    public static class MaxConsecutiveOnesIII
    {
        //Source: https://leetcode.com/problems/max-consecutive-ones-iii/solutions/6401489/simple-best-solution-by-iqbaldiit-7486/
        /*
         Given a binary array nums and an integer k, return the maximum number of 
         consecutive 1's in the array if you can flip at most k 0's.

            Example 1:
            Input: nums = [1,1,1,0,0,0,1,1,1,1,0], k = 2
            Output: 6
            Explanation: [1,1,1,0,0,1,1,1,1,1,1]
            Bolded numbers were flipped from 0 to 1. The longest subarray is underlined.

            Example 2:
            Input: nums = [0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1], k = 3
            Output: 10
            Explanation: [0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1]
            Bolded numbers were flipped from 0 to 1. The longest subarray is underlined.
 

            Constraints:

            1 <= nums.length <= 105
            nums[i] is either 0 or 1.
            0 <= k <= nums.length
 
         */
        static int LongestOnes(int[] nums, int k)
        {
            int nLeft = 0; // Left pointer of the window
            int nZeroCount = 0; // Count of 0's in the current window
            int nMaxLength = 0; // Maximum length of the window

            for (int right = 0; right < nums.Length; right++)
            {
                // If the current element is 0, increment zeroCount
                if (nums[right] == 0)
                {
                    nZeroCount++;
                }

                // If zeroCount exceeds k, shrink the window from the left
                while (nZeroCount > k)
                {
                    if (nums[nLeft] == 0)
                    {
                        nZeroCount--;
                    }
                    nLeft++;
                }

                // Update the maximum window size
                nMaxLength = Math.Max(nMaxLength, right - nLeft + 1);
            }

            return nMaxLength;
        }
        public static void Execute()
        {
            Console.WriteLine((LongestOnes([1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], 2)));// Output: 6
            Console.WriteLine((LongestOnes([0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1], 3)));// Output:10
        }
    }


}

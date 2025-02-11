using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.SlidingWindow
{
    //Source: https://leetcode.com/problems/longest-subarray-of-1s-after-deleting-one-element/solutions/6406834/simple-best-solution/
    public static class LongestSubArrayDeletingOneElement
    {
        /*
            Given a binary array nums, you should delete one element from it.
            Return the size of the longest non-empty subarray containing only 1's in 
            the resulting array. Return 0 if there is no such subarray.

            Example 1:
            Input: nums = [1,1,0,1]
            Output: 3
            Explanation: After deleting the number in position 2, [1,1,1] contains 3 numbers with value of 1's.
            
            Example 2:
            Input: nums = [0,1,1,1,0,1,1,0,1]
            Output: 5
            Explanation: After deleting the number in position 4, [0,1,1,1,1,1,0,1] longest subarray with value of 1's is [1,1,1,1,1].
            
            Example 3:
            Input: nums = [1,1,1]
            Output: 2
            Explanation: You must delete one element.
 

            Constraints:

            1 <= nums.length <= 105
            nums[i] is either 0 or 1.         
         */
        static int LongestSubarray(int[] nums)
        {
            int nLeft = 0, nRight = 0;
            int nMaxLen = 0, nZeroCount = 0;

            while (nRight < nums.Length)
            {
                if (nums[nRight] == 0)
                {
                    nZeroCount++;
                }

                while (nZeroCount > 1)
                {
                    if (nums[nLeft] == 0)
                    {
                        nZeroCount--;
                    }
                    nLeft++;
                }

                nMaxLen = Math.Max(nMaxLen, nRight - nLeft);
                nRight++;
            }

            return nMaxLen;
        }
        public static void Execute()
        {
            Console.WriteLine(LongestSubarray([0, 1, 1, 1, 0, 1, 1, 0, 1]));
            Console.WriteLine(LongestSubarray([1, 1, 0, 1]));
            Console.WriteLine(LongestSubarray([1, 1, 1]));
        }
    }
}

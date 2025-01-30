using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.ArrayString
{
    // Source: https://leetcode.com/problems/increasing-triplet-subsequence/solutions/6346500/simple-best-solution-by-iqbaldiit-1jk9/
    /*
        Given an integer array nums, return true if there exists a triple of indices (i, j, k) 
        such that i < j < k and nums[i] < nums[j] < nums[k]. 
        If no such indices exists, return false. 

        Example 1:

        Input: nums = [1,2,3,4,5]
        Output: true
        Explanation: Any triplet where i < j < k is valid.

        Example 2:
        Input: nums = [5,4,3,2,1]
        Output: false
        Explanation: No triplet exists.

        Example 3:
        Input: nums = [2,1,5,0,4,6]
        Output: true
        Explanation: The triplet (3, 4, 5) is valid because nums[3] == 0 < nums[4] == 4 < nums[5] == 6.
 

        Constraints:

        1 <= nums.length <= 5 * 105
        -231 <= nums[i] <= 231 - 1
 

        Follow up: Could you implement a solution that runs in O(n) time complexity and O(1) space complexity?     
     */
    public static class IncreasingTripletSubsequence
    {
        private static bool IncreasingTriplet(int[] nums)
        {
            // first and Smallest element
            int nFirst = int.MaxValue, nSecond = int.MaxValue;
            foreach (int num in nums) { 
                if (num <= nFirst) {nFirst=num;} // Update smallest element
                else if (num <= nSecond) {nSecond=num; } // Update smallest element
                else {return true;}
            }
            return false;
        }

        public static void Execute()
        {
            //int[] nums = [2, 1, 5, 0, 4, 6];           
            
            Console.WriteLine(IncreasingTriplet([1, 2, 3, 4, 5])); // True
            Console.WriteLine(IncreasingTriplet([2, 4, -2, -3])); // False
            Console.WriteLine(IncreasingTriplet([5, 4, 3, 2, 1])); // False            
            Console.WriteLine(IncreasingTriplet([2, 1, 5, 0, 4, 6])); // True
        }
    }
}

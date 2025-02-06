using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.TwoPointers
{
    //Source: https://leetcode.com/problems/max-number-of-k-sum-pairs/solutions/6383180/simple-best-solution-by-iqbaldiit-o7ao/
    /*
        You are given an integer array nums and an integer k.
        In one operation, you can pick two numbers from the array whose sum equals k 
        and remove them from the array.
        Return the maximum number of operations you can perform on the array. 

        Example 1:
        Input: nums = [1,2,3,4], k = 5
        Output: 2
        Explanation: Starting with nums = [1,2,3,4]:
        - Remove numbers 1 and 4, then nums = [2,3]
        - Remove numbers 2 and 3, then nums = []
        There are no more pairs that sum up to 5, hence a total of 2 operations.

        Example 2:
        Input: nums = [3,1,3,4,3], k = 6
        Output: 1
        Explanation: Starting with nums = [3,1,3,4,3]:
        - Remove the first two 3's, then nums = [1,4,3]
        There are no more pairs that sum up to 6, hence a total of 1 operation.
 

        Constraints:
        1 <= nums.length <= 105
        1 <= nums[i] <= 109
        1 <= k <= 109
        Seen this question in a real interview before?
        1/5     
     */
    public static class MaxNumberOfKSumPairs
    {
        private static int MaxOperations(int[] nums, int k)
        {
            // Initializa a dictionaary.
            Dictionary<int, int> dicFreq = new Dictionary<int, int>();
            int nOperations = 0;

            foreach (int num in nums)
            {
                int nComplement = k - num;
                //check the complement as a key exists and its value >0
                if (dicFreq.ContainsKey(nComplement) && dicFreq[nComplement] > 0)
                {
                    // if exists, means there is one pair whose sum=k.
                    // So, decrease the value of the key, not to pick second time. 
                    nOperations++;
                    dicFreq[nComplement]--;
                }
                else
                {
                    // if complement as key not exists, add num as key and value as 0
                    if (!dicFreq.ContainsKey(num))
                    {
                        dicFreq[num] = 0;
                    }
                    dicFreq[num]++; // increase value if found
                }
            }
            return nOperations;
        }

        public static void Execute()
        {
            Console.WriteLine(MaxOperations([1, 2, 3, 4], 5));
            Console.WriteLine(MaxOperations([3, 1, 3, 4, 3], 6));
        }
    }
}

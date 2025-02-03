using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.TwoPointers
{
    //Source: https://leetcode.com/problems/move-zeroes/solutions/6365692/simple-best-solution-by-iqbaldiit-dxfv/
    /*
        Given an integer array nums, move all 0's to the end of it 
        while maintaining the relative order of the non-zero elements.
        Note that you must do this in-place without making a copy of the array.
    
        Example 1:
        Input: nums = [0,1,0,3,12]
        Output: [1,3,12,0,0]

        Example 2:
        Input: nums = [0]
        Output: [0]
 

        Constraints:
        1 <= nums.length <= 104
        -231 <= nums[i] <= 231 - 1
        Follow up: Could you minimize the total number of operations done?

     */
    public static class MoveZeros
    {
        // Approach:1
        private static int[] MoveZeroesV1(int[] nums)
        {            
            // initialize a temporary array where the sorting result will be kept
            int[] temp = new int[nums.Length];
            int nTempIndex = 0; // set temp array index 0

            // Set non Zero elements from the first in temp array
            for (int i = 0; i < nums.Length; i++) {                
                if (nums[i] != 0) {  
                    temp[nTempIndex] = nums[i];
                    nTempIndex++; 
                }                
            }
            
            // set all 0 rest of the elements
            while (nTempIndex < nums.Length) {
                temp[nTempIndex] = 0;
                nTempIndex++;
            }

            return temp;
        }

        //Approach 2
        private static int[] MoveZeroesV2(int[] nums)
        {
            int nWritePointer = 0; // set temp array index 0

            // Set non Zero elements from the first in temp array
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[nWritePointer] = nums[i];
                    nWritePointer++;
                }
            }

            // set all 0 rest of the elements
            while (nWritePointer < nums.Length)
            {
                nums[nWritePointer] = 0;
                nWritePointer++;
            }

            return nums;
        }

        //Approach 3 (Recommended)
        private static int[] MoveZeroesV3(int[] nums)
        {
            int lastNonZeroFoundAt = 0;

            // Move all non-zero elements to the front
            for (int current = 0; current < nums.Length; current++)
            {
                if (nums[current] != 0)
                {
                    // Swap elements
                    int temp = nums[current];
                    nums[current] = nums[lastNonZeroFoundAt];
                    nums[lastNonZeroFoundAt] = temp;

                    lastNonZeroFoundAt++;
                }
            }

            return nums;
        }

        public static void Execute()
        {
            int[] nums = [0, 1, 0, 3, 12];
            int[] aResult=MoveZeroesV3(nums);
            var sResult=string.Join(", ", aResult);
            Console.WriteLine(sResult);
        }
    }
}

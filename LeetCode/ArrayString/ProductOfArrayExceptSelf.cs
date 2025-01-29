using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.ArrayString
{
    //Source: https://leetcode.com/problems/product-of-array-except-self/solutions/6342700/simple-best-solution/
    /*
        Given an integer array nums, return an array answer such that answer[i] 
        is equal to the product of all the elements of nums except nums[i].

        The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
        You must write an algorithm that runs in O(n) time and without using the division operation.

 

    Example 1:

    Input: nums = [1,2,3,4]
    Output: [24,12,8,6]
    Example 2:

    Input: nums = [-1,1,0,-3,3]
    Output: [0,0,9,0,0]
 

    Constraints:

    2 <= nums.length <= 105
    -30 <= nums[i] <= 30
    The input is generated such that answer[i] is guaranteed to fit in a 32-bit integer.
     */
    public static class ProductOfArrayExceptSelf
    {
        private static int[] ProductExceptSelf(int[] nums)
        {
            int n=nums.Length;
            int[] ans = new int[n];

            ////Approach 1 : using nested loop. But It has time complexity
            //for (int i=0;i<n;i++) {
            //    int product = 1;
            //    foreach (int j in nums)
            //    {                    
            //        if (nums[i]!=j) product= product*j;
            //    }
            //    ans[i]=product;
            //}

            // Approach 2: Seperate loop considering prefix and suffix
            // Step 1: Calclate prefix product
            ans[0] = 1;// As there is no elements, set 1 to the first element.
            for (int i = 1; i < n; i++)
            {
                ans[i] = ans[i - 1] * nums[i-1];
            }

            //Step: Calculate suffix product and multiply with prefix product
            int nSuffixProduct = 1; // As there is no element from the right
            for (int i = n - 1; i >= 0; i--)
            {
                ans[i]*=nSuffixProduct; // multiply prefix product with suffix product
                nSuffixProduct*=nums[i];// update suffix profuct for the next iteration.
            }

            return ans;
        }

        public static void Execute()
        {
            int[] nums = [1, 2, 3, 4];
            int[] result = ProductExceptSelf(nums);
            string formattedList="["+string.Join(", ",result)+"]";
            Console.WriteLine(formattedList);
        }
    }
}

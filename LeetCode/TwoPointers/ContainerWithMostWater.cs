using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.TwoPointers
{
    // Source: https://leetcode.com/problems/container-with-most-water/description/?envType=study-plan-v2&envId=leetcode-75
    // Solution: https://leetcode.com/problems/container-with-most-water/solutions/6377481/simple-best-solution-by-iqbaldiit-gxpm/
    /*
        You are given an integer array height of length n. 
        There are n vertical lines drawn such that the two endpoints of 
        the ith line are (i, 0) and (i, height[i]).

        Find two lines that together with the x-axis form a container, 
        such that the container contains the most water.

        Return the maximum amount of water a container can store.

        Notice that you may not slant the container.

 

        Example 1:


        Input: height = [1,8,6,2,5,4,8,3,7]
        Output: 49
        Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.
        Example 2:

        Input: height = [1,1]
        Output: 1
 

        Constraints:

        n == height.length
        2 <= n <= 105
        0 <= height[i] <= 104     
     */
    public static class ContainerWithMostWater
    {
        static int nMaxArea(int[] height)
        {
            int nLeft = 0;
            int nRight = height.Length - 1;
            int nMaxArea = 0;

            while (nLeft < nRight)
            {
                int nWidth = nRight - nLeft;
                int nMinHeight = Math.Min(height[nLeft], height[nRight]);
                nMaxArea = Math.Max(nMaxArea, nWidth * nMinHeight);

                if (height[nLeft] < height[nRight])
                {
                    nLeft++;
                }
                else
                {
                    nRight--;
                }
            }

            return nMaxArea;
        }

        public static void Execute()
        {
            Console.WriteLine(nMaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]));// Output: 49
            Console.WriteLine(nMaxArea([1, 8, 6, 2]));// Output: 6
            Console.WriteLine(nMaxArea([1, 7, 8, 6, 2, 5, 4, 8, 3]));// Output: 42
            Console.WriteLine(nMaxArea([1, 1]));// Output: 1
        }
    }
}

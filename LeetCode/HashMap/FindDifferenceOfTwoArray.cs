using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.HashMap
{
    public static class FindDifferenceOfTwoArray
    {
        //Source: https://leetcode.com/problems/find-the-difference-of-two-arrays/solutions/6428309/best-simple-solution-by-iqbaldiit-1127/
        /*
            Given two 0-indexed integer arrays nums1 and nums2, 
            return a list answer of size 2 where:

            answer[0] is a list of all distinct integers in nums1 which are not present 
            in nums2.
            answer[1] is a list of all distinct integers in nums2 which are not present 
            in nums1.
            Note that the integers in the lists may be returned in any order. 

            Example 1:
            Input: nums1 = [1,2,3], nums2 = [2,4,6]
            Output: [[1,3],[4,6]]
            Explanation:
            For nums1, nums1[1] = 2 is present at index 0 of nums2, whereas nums1[0] = 1 and nums1[2] = 3 are not present in nums2. Therefore, answer[0] = [1,3].
            For nums2, nums2[0] = 2 is present at index 1 of nums1, whereas nums2[1] = 4 and nums2[2] = 6 are not present in nums2. Therefore, answer[1] = [4,6].
            
            Example 2:
            Input: nums1 = [1,2,3,3], nums2 = [1,1,2,2]
            Output: [[3],[]]
            Explanation:
            For nums1, nums1[2] and nums1[3] are not present in nums2. Since nums1[2] == nums1[3], their value is only included once and answer[0] = [3].
            Every integer in nums2 is present in nums1. Therefore, answer[1] = [].
 
            Constraints:

            1 <= nums1.length, nums2.length <= 1000
            -1000 <= nums1[i], nums2[i] <= 1000         
         */
        static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            // Convert to set because of remove duplicates
            HashSet<int> set1 = new HashSet<int>(nums1);
            HashSet<int> set2 = new HashSet<int>(nums2);

            IList<int> result1 = new List<int>();
            IList<int> result2 = new List<int>();

            foreach (var item in set1)
            {
                if (!set2.Contains(item))
                {
                    result1.Add(item);
                }
            }

            foreach (var item in set2)
            {
                if (!set1.Contains(item))
                {
                    result2.Add(item);
                }
            }
            return new List<IList<int>> { result1, result2 };
        }
        public static void Execute()
        {
            var result1 = FindDifference([1, 2, 3], [2, 4, 6]);
            var result2 = FindDifference([1, 2, 3, 3], [1, 1, 2, 2]);
            Console.WriteLine("[" + string.Join(", ", result1[0]) + "], [" + string.Join(", ", result1[1]) + "]");
            Console.WriteLine("[" + string.Join(", ", result2[0]) + "], [" + string.Join(", ", result2[1]) + "]");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode
{
    public static class MergeSortedArray
    {
        //Approach 1
        private static int[] MergeSortedArrayV1(int[] nums1, int m, int[] nums2, int n)
        {
            // 1st Solution using loop
            var firstNumIndex = m - 1;
            var secondNumIndex = n - 1;
            var resultIndex = m + n - 1;

            while (secondNumIndex >= 0)
            {
                if (firstNumIndex > 0 && nums1[firstNumIndex] > nums2[secondNumIndex])
                {
                    nums1[resultIndex] = nums1[firstNumIndex];
                    firstNumIndex--;
                }
                else
                {
                    nums1[resultIndex] = nums2[secondNumIndex];
                    secondNumIndex--;
                }
                resultIndex--;

            }
            Array.Sort(nums1);
            return nums1;
        }

        // Approach 2
        private static int[] MergeSortedArrayV2(int[] nums1, int m, int[] nums2, int n)
        {
            Array.Copy(nums2, 0, nums1, m, n);
            Array.Sort(nums1);
            return nums1;
        }

        // call the following methods from program.cs file to see result
        public static void ExecuteV1() {
            var sortedArray = MergeSortedArrayV1([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
            System.Console.WriteLine(String.Join(",", sortedArray));
        }

        public static void ExecuteV2()
        {
            var sortedArray2 = MergeSortedArrayV2([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
            System.Console.WriteLine(String.Join(",", sortedArray2));
        }


    }
}

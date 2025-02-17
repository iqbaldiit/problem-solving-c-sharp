using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.HashMap
{
    public static class UniqueNumberOfOccurrences
    {
        // Sourcr: https://leetcode.com/problems/unique-number-of-occurrences/solutions/6431820/best-simple-solution-by-iqbaldiit-ucnm/
        /*
            Given an array of integers arr, return true if the number of occurrences of each value in 
            the array is unique or false otherwise.        

            Example 1:
            Input: arr = [1,2,2,1,1,3]
            Output: true
            Explanation: The value 1 has 3 occurrences, 2 has 2 and 3 has 1. 
                          No two values have the same number of occurrences.
            
            Example 2:
            Input: arr = [1,2]
            Output: false

            Example 3:
            Input: arr = [-3,0,1,-3,1,1,1,-3,10,0]
            Output: true
 

            Constraints:

            1 <= arr.length <= 1000
            -1000 <= arr[i] <= 1000         
         */
        static bool UniqueOccurrences(int[] arr)
        {
            //// Approach 1
            //HashSet<int> setArr=new HashSet<int>(arr);
            //List<int> list = new List<int>();

            //foreach (var i in setArr)
            //{
            //    var count = 0;
            //    foreach (var j in arr)
            //    {
            //        if (i == j)
            //            count++;
            //    }
            //    list.Add(count);
            //}
            //HashSet<int> setResult = new HashSet<int>(list);
            //return (setResult.Count()==list.Count());

            // Approach 2 (Recommanded)
            Dictionary<int, int> dicCount= new Dictionary<int, int>();
            foreach (int i in arr) {
                if (dicCount.ContainsKey(i)){
                    dicCount[i]++;
                }
                else { 
                    dicCount[i] = 1;
                }
            }
            HashSet<int> setCount = new HashSet<int>(dicCount.Values);
            return setCount.Count()==dicCount.Count();
        }

        public static void Execute()
        {
            Console.WriteLine(UniqueOccurrences([1, 2, 2, 1, 1, 3]));// True
            Console.WriteLine(UniqueOccurrences([1, 2]));//False
            Console.WriteLine(UniqueOccurrences([-3, 0, 1, -3, 1, 1, 1, -3, 10, 0]));// True
        }
    }
}

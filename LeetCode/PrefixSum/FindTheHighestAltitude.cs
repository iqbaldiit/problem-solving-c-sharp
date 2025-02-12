using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.PrefixSum
{
    //Source: https://leetcode.com/problems/find-the-highest-altitude/solutions/6411245/simple-best-solution-by-iqbaldiit-anvg/
    /*
        There is a biker going on a road trip. The road trip consists of n + 1 points 
        at different altitudes. The biker starts his trip on point 0 with altitude equal 0.

        You are given an integer array gain of length n where gain[i] is the net gain 
        in altitude between points i​​​​​​ and i + 1 for all (0 <= i < n). Return the highest 
        altitude of a point. 

        Example 1:
        Input: gain = [-5,1,5,0,-7]
        Output: 1
        Explanation: The altitudes are [0,-5,-4,1,1,-6]. The highest is 1.

        Example 2:
        Input: gain = [-4,-3,-2,-1,4,3,2]
        Output: 0
        Explanation: The altitudes are [0,-4,-7,-9,-10,-6,-3,-1]. The highest is 0. 

        Constraints:
        n == gain.length
        1 <= n <= 100
        -100 <= gain[i] <= 100     
     */
    public static class FindTheHighestAltitude
    {
        static int LargestAltitude(int[] gain)
        {

            //Approach: 1
            //int nMaxAltitude = 0;
            //int[] aryResult= new int[gain.Length+1];
            //aryResult[0]=0;
            //for (int i = 0; i < gain.Length; i++)
            //{
            //    aryResult[i + 1] = aryResult[i] + gain[i];
            //}
            //nMaxAltitude= aryResult.Max();

            //Approach: 2 (Recommended)
            int nMaxAltitude = 0;
            int nCurrentAltitude=0;

            foreach (var g in gain)
            {
                nCurrentAltitude += g;
                nMaxAltitude = nCurrentAltitude > nMaxAltitude ? nCurrentAltitude : nMaxAltitude;
            }
            return nMaxAltitude;

        }
        public static void Execute()
        {
            Console.WriteLine(LargestAltitude([-5, 1, 5, 0, -7]));
            Console.WriteLine(LargestAltitude([-4, -3, -2, -1, 4, 3, 2]));            
        }
    }
}

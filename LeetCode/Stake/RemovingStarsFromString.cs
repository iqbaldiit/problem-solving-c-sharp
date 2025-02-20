using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.Stake
{
    /*
        You are given a string s, which contains stars *.
        In one operation, you can:
        Choose a star in s.
        Remove the closest non-star character to its left, 
        as well as remove the star itself.
        Return the string after all stars have been removed.

        Note:
        The input will be generated such that the operation is always possible.
        It can be shown that the resulting string will always be unique.
 

        Example 1:

        Input: s = "leet**cod*e"
        Output: "lecoe"
        Explanation: Performing the removals from left to right:
        - The closest character to the 1st star is 't' in "leet**cod*e". s becomes "lee*cod*e".
        - The closest character to the 2nd star is 'e' in "lee*cod*e". s becomes "lecod*e".
        - The closest character to the 3rd star is 'd' in "lecod*e". s becomes "lecoe".
        There are no more stars, so we return "lecoe".
        Example 2:

        Input: s = "erase*****"
        Output: ""
        Explanation: The entire string is removed, so we return an empty string.
 

        Constraints:

        1 <= s.length <= 105
        s consists of lowercase English letters and stars *.
        The operation above can be performed on s.     
     */
    public static class RemovingStarsFromString
    {
        // Source: https://leetcode.com/problems/removing-stars-from-a-string/solutions/6445342/best-simple-solution-beats-89-91-by-iqba-xdjh/
        static string RemoveStars(string s)
        {
            //// Approach: 1
            //string sResult = "";
            //foreach (char c in s) { 
            //    if (c == '*')
            //    {
            //        if (sResult.Length > 0)  
            //            sResult=sResult.Remove(sResult.Length - 1);

            //    }else 
            //        sResult += c;
            //}
            //return sResult;

            //Approach: 2
            Stack<char> stkS = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '*')
                {
                    if (stkS.Count > 0)
                    {
                        stkS.Pop();
                    }
                }
                else
                {
                    stkS.Push(c);
                }
            }

            char[] aryResult = stkS.ToArray();
            Array.Reverse(aryResult);
            return new string(aryResult);
        }

        public static void Execute() // Call from program.cs
        {
            Console.WriteLine(RemoveStars("leet**cod*e"));
            Console.WriteLine(RemoveStars("erase*****"));
        }
    }
}

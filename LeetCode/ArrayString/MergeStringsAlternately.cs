using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

/*
 * Source: https://leetcode.com/problems/merge-strings-alternately/solutions/6314317/simple-best-solution-by-iqbaldiit-qc48/
 
You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. 
If a string is longer than the other, append the additional letters onto the end of the merged string.

Return the merged string. 

Example 1:

Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"
Explanation: The merged string will be merged as so:
word1:  a   b   c
word2:    p   q   r
merged: a p b q c r
Example 2:

Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"
Explanation: Notice that as word2 is longer, "rs" is appended to the end.
word1:  a   b 
word2:    p   q   r   s
merged: a p b q   r   s
Example 3:

Input: word1 = "abcd", word2 = "pq"
Output: "apbqcd"
Explanation: Notice that as word1 is longer, "cd" is appended to the end.
word1:  a   b   c   d
word2:    p   q 
merged: a p b q c   d
 

Constraints:

1 <= word1.length, word2.length <= 100
word1 and word2 consist of lowercase English letters.
 */

namespace DataStructureAlgorithm.LeetCode.ArrayString
{
    public static class MergeStringsAlternately
    {
        public static string MergeAlternately(string word1, string word2)
        {
            StringBuilder sResult = new StringBuilder();
            var i = 0; var j = 0;

            // Loop through both strings until we reach the end of one of them
            while (i < word1.Length && j < word2.Length)
            {
                sResult.Append(word1[i]);
                sResult.Append(word2[j]);
                i++;
                j++;
            }

            // If word1 is longer, append the remaining characters
            while (i < word1.Length) { 
                sResult.Append(word1[i]); 
                i++;
            }

            // If word2 is longer, append the remaining characters
            while (j < word2.Length)
            {
                sResult.Append(word2[j]);
                j++;
            }
           
            return sResult.ToString();
        }

        public static void Execute()
        {
            var word1 = "abc";
            var word2 = "123";
            var sResult=MergeAlternately(word1, word2);
            Console.WriteLine(sResult);
        }
    }
}

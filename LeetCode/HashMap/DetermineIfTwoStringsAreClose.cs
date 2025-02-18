using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.HashMap
{
    //Source https://leetcode.com/problems/determine-if-two-strings-are-close/solutions/6436209/best-simple-solution/?envType=study-plan-v2&envId=leetcode-75
    public static class DetermineIfTwoStringsAreClose
    {
        /*
        Two strings are considered close if you can attain one from the other using 
        the following operations:

        Operation 1: Swap any two existing characters.
        For example, abcde -> aecdb

        Operation 2: Transform every occurrence of one existing character into 
        another existing character, and do the same with the other character.

        For example, aacabb -> bbcbaa (all a's turn into b's, and all b's turn into a's)
        You can use the operations on either string as many times as necessary.

        Given two strings, word1 and word2, return true if word1 and word2 are close, 
        and false otherwise.

 

        Example 1:

        Input: word1 = "abc", word2 = "bca"
        Output: true
        Explanation: You can attain word2 from word1 in 2 operations.
        Apply Operation 1: "abc" -> "acb"
        Apply Operation 1: "acb" -> "bca"
        
        Example 2:
        Input: word1 = "a", word2 = "aa"
        Output: false
        Explanation: It is impossible to attain word2 from word1, or vice versa, in any number of operations.
        Example 3:

        Input: word1 = "cabbba", word2 = "abbccc"
        Output: true
        Explanation: You can attain word2 from word1 in 3 operations.
        Apply Operation 1: "cabbba" -> "caabbb"
        Apply Operation 2: "caabbb" -> "baaccc"
        Apply Operation 2: "baaccc" -> "abbccc"
 

        Constraints:

        1 <= word1.length, word2.length <= 105
        word1 and word2 contain only lowercase English letters.         
         */
        static bool CloseStrings(string word1, string word2)
        {      
            // Check if the sets of characters are the same
            if (word1.Length != word2.Length) return false;

            var charSet1 = new HashSet<char>(word1);
            var charSet2 = new HashSet<char>(word2);
            if (!charSet1.SetEquals(charSet2)) return false;

            // Count the frequency of each character
            var freq1 = new int[26];
            var freq2 = new int[26];
            foreach (char c in word1) freq1[c - 'a']++;
            foreach (char c in word2) freq2[c - 'a']++;

            // Sort the frequency counts and compare
            Array.Sort(freq1);
            Array.Sort(freq2);
            return freq1.SequenceEqual(freq2);
            
        }
        public static void Execute()
        {
            Console.WriteLine(CloseStrings("abc", "bca"));
            Console.WriteLine(CloseStrings("a", "aa"));
            Console.WriteLine(CloseStrings("cabbba", "abbccc"));
        }
    }
}

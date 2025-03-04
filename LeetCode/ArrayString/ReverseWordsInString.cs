﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.ArrayString
{
    // Source: https://leetcode.com/problems/reverse-words-in-a-string/solutions/6338476/simple-best-using-reverse-function-by-iq-96cu/
    /*
        Given an input string s, reverse the order of the words.

        A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.

        Return a string of the words in reverse order concatenated by a single space.

        Note that s may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. Do not include any extra spaces.

 

        Example 1:

        Input: s = "the sky is blue"
        Output: "blue is sky the"
        Example 2:

        Input: s = "  hello world  "
        Output: "world hello"
        Explanation: Your reversed string should not contain leading or trailing spaces.
        Example 3:

        Input: s = "a good   example"
        Output: "example good a"
        Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.
 

        Constraints:

        1 <= s.length <= 104
        s contains English letters (upper-case and lower-case), digits, and spaces ' '.
        There is at least one word in s.
 

        Follow-up: If the string data type is mutable in your language, can you solve it in-place with O(1) extra space?
     
     */
    public static class ReverseWordsInString
    {
        private static string ReverseWords(string s)
        {
            // Convert string to list removing extra space.
            List<string> words = s.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();

            //// Approach 1
            //List<string> result = new List<string>();
            //int length = words.Count;
            //for (int i = 0; i < length; i++)
            //{
            //    result.Add(words[length - 1 - i]);
            //}
            //return string.Join(' ', result);

            ////Approach 2: Improve memory and performance. (Using two pointer)
            //int nnLeft = 0, nnRight = words.Count - 1;

            //while (nnLeft < nnRight)
            //{
            //    var temp = words[nnLeft];
            //    words[nnLeft] = words[nnRight];
            //    words[nnRight] = temp;
            //    nnLeft++;
            //    nnRight--;
            //}
            //return string.Join(' ', words);

            // Approach 3: Using reverse function
            words.Reverse(); // reverse the word list
            return string.Join(' ', words);
        }

        public static void Execute()
        {
            string sInpute = "Sky is              the limit ";
            Console.WriteLine(ReverseWords(sInpute));
        }
    }
    
}

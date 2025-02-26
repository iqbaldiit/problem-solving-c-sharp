using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.Stake
{
    //Source: https://leetcode.com/problems/decode-string/solutions/6471100/best-simple-solution-by-iqbaldiit-joy4/
    /*
     Given an encoded string, return its decoded string.
     The encoding rule is: k[encoded_string], where the encoded_string inside the square 
     brackets is being repeated exactly k times. Note that k is guaranteed to be a 
     positive integer.
    
    You may assume that the input string is always valid; there are no extra white spaces, 
     square brackets are well-formed, etc. Furthermore, you may assume that the original 
     data does not contain any digits and that digits are only for those repeat numbers, 
     k. For example, there will not be input like 3a or 2[4].
     
    The test cases are generated so that the length of the output will never exceed 105.

    Example 1:
    Input: s = "3[a]2[bc]"
    Output: "aaabcbc"

    Example 2:
    Input: s = "3[a2[c]]"
    Output: "accaccacc"

    Example 3:
    Input: s = "2[abc]3[cd]ef"
    Output: "abcabccdcdcdef"
 

        Constraints:
        1 <= s.length <= 30
        s consists of lowercase English letters, digits, and square brackets '[]'.
        s is guaranteed to be a valid input.
        All the integers in s are in the range [1, 300].
     */
    public static class DecodeString
    {
        static string DecodeStr(string s)
        {
            Stack<int> countStack = new Stack<int>();
            Stack<StringBuilder> stringStack = new Stack<StringBuilder>();
            StringBuilder currentString = new StringBuilder();
            int k = 0;

            foreach (char ch in s)
            {
                if (char.IsDigit(ch))
                {
                    k = k * 10 + (ch - '0');
                }
                else if (ch == '[')
                {
                    countStack.Push(k);
                    stringStack.Push(currentString);
                    currentString = new StringBuilder();
                    k = 0;
                }
                else if (ch == ']')
                {
                    StringBuilder decodedString = stringStack.Pop();
                    int currentK = countStack.Pop();
                    for (int i = 0; i < currentK; i++)
                    {
                        decodedString.Append(currentString);
                    }
                    currentString = decodedString;
                }
                else
                {
                    currentString.Append(ch);
                }
            }

            return currentString.ToString();
        }
        public static void Execute()
        {
            //Console.WriteLine(DecodeStr("3[a]2[bc]"));
            Console.WriteLine(DecodeStr("3[a2[c]]"));
            //Console.WriteLine(DecodeStr("2[abc]3[cd]ef"));
        }
    }
}

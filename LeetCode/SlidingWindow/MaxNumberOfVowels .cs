using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.SlidingWindow
{
    /*
        Given a string s and an integer k, return the maximum number of 
        vowel letters in any substring of s with length k.
        Vowel letters in English are 'a', 'e', 'i', 'o', and 'u'.
    
        Example 1:
        Input: s = "abciiidef", k = 3
        Output: 3
        Explanation: The substring "iii" contains 3 vowel letters.

        Example 2:
        Input: s = "aeiou", k = 2
        Output: 2
        Explanation: Any substring of length 2 contains 2 vowels.

        Example 3:
        Input: s = "leetcode", k = 3
        Output: 2
        Explanation: "lee", "eet" and "ode" contain 2 vowels.
 

        Constraints:

        1 <= s.length <= 105
        s consists of lowercase English letters.
        1 <= k <= s.length     
     */
    public static class MaxNumberOfVowels
    {
        static int MaxVowels(string s, int k)
        {

            int nMaxVowels = 0;
            int nCurrentVowels = 0;
            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            // Calculate the number of vowels in the first window
            for (int i = 0; i < k; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    nCurrentVowels++;
                }
            }
            nMaxVowels = nCurrentVowels;

            // Slide the window across the string
            for (int i = k; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    nCurrentVowels++;
                }
                if (vowels.Contains(s[i - k]))
                {
                    nCurrentVowels--;
                }
                nMaxVowels = Math.Max(nMaxVowels, nCurrentVowels);
            }

            return nMaxVowels;
        }

        public static void Execute()
        {
            Console.WriteLine((MaxVowels("abciiidef", 3)));
            Console.WriteLine((MaxVowels("aeiou", 3)));
            Console.WriteLine((MaxVowels("leetcode", 3)));
        }
    }
}

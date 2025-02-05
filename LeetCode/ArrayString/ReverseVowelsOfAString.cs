using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.ArrayString
{
    //Source: https://leetcode.com/problems/reverse-vowels-of-a-string/solutions/6333834/simple-best-solution-with-using-two-pointer/?envType=study-plan-v2&envId=leetcode-75
    /*
        Given a string s, reverse only all the vowels in the string and return it.

        The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

 

        Example 1:

        Input: s = "IceCreAm"

        Output: "AceCreIm"

        Explanation:

        The vowels in s are ['I', 'e', 'e', 'A']. On reversing the vowels, s becomes "AceCreIm".

        Example 2:

        Input: s = "leetcode"

        Output: "leotcede"

 

        Constraints:

        1 <= s.length <= 3 * 105
        s consist of printable ASCII characters.     
     */
    public static class ReverseVowelsOfAString
    {
        // Approach 1:

        //private static string ReverseVowels(string s)
        //{
        //    char[] aryStr=s.ToCharArray();
        //    string sVowelsInString = "";
        //    int nNumOfVowels = 0;
        //    //Set The vowel array
        //    char[] vowels = [ 'a', 'e','i','o','u', 'A', 'E', 'I', 'O', 'U'];

        //    //Collect All vowels from String
        //    for (int i = 0; i < aryStr.Length; i++)
        //    {
        //        if (vowels.Contains(aryStr[i]))
        //        {
        //            sVowelsInString += s[i];
        //            nNumOfVowels++;
        //        }
        //    }

        //    // Reverse the vowels
        //    for (int i = 0; i < aryStr.Length; i++)
        //    {                
        //        if (vowels.Contains(s[i]))
        //            aryStr[i]= sVowelsInString[--nNumOfVowels];
        //    }
        //    return String.Join("",aryStr);
        //}

        // Approach 2 (More effecient and less memory used.)
        private static string ReverseVowels(string s)
        {
            char[] aryStr = s.ToCharArray();
            int nLeft = 0;
            int nRight = aryStr.Length - 1;

            // Set the vowel array
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            // Two-pointer approach to reverse vowels in place
            while (nLeft < nRight)
            {
                // Move nLeft pointer until a vowel is found
                while (nLeft < nRight && !vowels.Contains(aryStr[nLeft]))
                {
                    nLeft++;
                }

                // Move nRight pointer until a vowel is found
                while (nLeft < nRight && !vowels.Contains(aryStr[nRight]))
                {
                    nRight--;
                }

                // Swap the vowels
                if (nLeft < nRight)
                {
                    char temp = aryStr[nLeft];
                    aryStr[nLeft] = aryStr[nRight];
                    aryStr[nRight] = temp;
                    nLeft++;
                    nRight--;
                }
            }

            return new string(aryStr);
        }


        public static void Execute()
        {
            string inputs = "IceCreAm";
            string outputs =ReverseVowels(inputs);
            Console.WriteLine(outputs);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.ArrayString
{
    /*
        For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t (i.e., t is concatenated with itself one or more times).

        Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.

 

        Example 1:

        Input: str1 = "ABCABC", str2 = "ABC"
        Output: "ABC"
        Example 2:

        Input: str1 = "ABABAB", str2 = "ABAB"
        Output: "AB"
        Example 3:

        Input: str1 = "LEET", str2 = "CODE"
        Output: ""
 

        Constraints:

        1 <= str1.length, str2.length <= 1000
        str1 and str2 consist of English uppercase letters.
     */
    public static class GreatestCommonDivisorOfStrings
    {
        static string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1)
            {
                return "";
            }
            return str1.Substring(0, GCD(str1.Length, str2.Length));            
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static void Execute()
        {
            string str1 = "ABABAB"; // Example input
            string str2 = "ABAB"; // Example input

            string result = GcdOfStrings(str1, str2);
            int x = GCD(6, 4);
            Console.WriteLine(x);

        }
    }
}

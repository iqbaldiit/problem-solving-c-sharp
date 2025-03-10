﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.ArrayString
{
    //Source: https://leetcode.com/problems/string-compression/solutions/6351764/simple-best-solution-by-iqbaldiit-sw33/
    /*
        Given an array of characters chars, compress it using the following algorithm:

        Begin with an empty string s. For each group of consecutive repeating characters in chars:

        If the group's length is 1, append the character to s.
        Otherwise, append the character followed by the group's length.
        The compressed string s should not be returned separately, but instead, be stored in the input character array chars. Note that group lengths that are 10 or longer will be split into multiple characters in chars.

        After you are done modifying the input array, return the new length of the array.

        You must write an algorithm that uses only constant extra space.

 

        Example 1:

        Input: chars = ["a","a","b","b","c","c","c"]
        Output: Return 6, and the first 6 characters of the input array should be: ["a","2","b","2","c","3"]
        Explanation: The groups are "aa", "bb", and "ccc". This compresses to "a2b2c3".
        Example 2:

        Input: chars = ["a"]
        Output: Return 1, and the first character of the input array should be: ["a"]
        Explanation: The only group is "a", which remains uncompressed since it's a single character.
        Example 3:

        Input: chars = ["a","b","b","b","b","b","b","b","b","b","b","b","b"]
        Output: Return 4, and the first 4 characters of the input array should be: ["a","b","1","2"].
        Explanation: The groups are "a" and "bbbbbbbbbbbb". This compresses to "ab12".
 

        Constraints:

        1 <= chars.length <= 2000
        chars[i] is a lowercase English letter, uppercase English letter, digit, or symbol.     
     */
    public static class LeetCodeStringCompression
    {
        private static int Compress(char[] chars)
        {
            int write = 0,//Pointer to read original array
                read = 0; //Pointer to write compressed array

            while (read < chars.Length) { 
                char currentChar = chars[read];
                int nCount = 0;
                
                //Count the number of consecutive repeating characters
                while (read < chars.Length && chars[read] == currentChar) { 
                    nCount++;
                    read++;
                }

                //Write the compressed char
                chars[write++] = currentChar;

                //Write count if greater than 1
                if (nCount > 1) {
                    foreach (var n in nCount.ToString())
                    {
                        chars[write++] = n;
                    }
                }

            }

            return write;
        }

        public static void Execute()
        {
            //char[] nInput = ['a', 'a', 'b', 'b', 'c', 'c', 'c'];
            //int nOutput = Compress(nInput);
            Console.WriteLine(Compress(['a', 'a', 'b', 'b', 'c', 'c', 'c'])); // Outputs = 6
            Console.WriteLine(Compress(['a'])); // Outputs = 1
            Console.WriteLine(Compress(['a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b']));// Outputs = 4
            Console.WriteLine(Compress(['a', 'b', 'b', 'b', 'b', 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b']));// Outputs = 6
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.Problems
{
    public static class ValidParentheses
    {

        public static bool IsValid(string s)
        {
            //check emty string
            if(string.IsNullOrEmpty(s)) return true;
            // odd string cant be valid
            if (s.Length %2 != 0) return false;

            // match brackets pair
            Dictionary<char, char> brackets = new Dictionary<char, char>{
                {'}','{' }
                ,{')','('}
                ,{']','['}
            };

            var stack = new Stack<char>();
            foreach (char c in s)
            {
                // If it's a closing bracket
                if (brackets.ContainsKey(c))
                {
                    // If stack is empty or top doesn't match, it's invalid
                    if (stack.Count == 0 || stack.Pop() != brackets[c])
                    {
                        return false;
                    }
                }
                // If it's an opening bracket
                else if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                // If it's any other character
                else
                {
                    return false;
                }
            }
            //foreach (char c in s)
            //{
            //    if (c == '(' || c == '{' || c == '[')
            //    {
            //        stack.Push(c);
            //    }
            //    else
            //    {
            //        if (stack.Count == 0)
            //        {
            //            return false;

            //        }

            //        char topElement = stack.Pop();
            //        if (c == ')' && topElement != '(')
            //        {
            //            return false;
            //        }
            //        if (c == '}' && topElement != '{')
            //        {
            //            return false;
            //        }
            //        if (c == ']' && topElement != '[')
            //        {
            //            return false;
            //        }
            //    }
            //}

            return stack.Count == 0;
        }

        public static void Execute()
        {
            string[] inputs = { "()", "{}", "{]}", "{}", "{(])}" };
            foreach (string input in inputs)
            {
                var sResult=IsValid(input)?"Valid":"Invalid";
                Console.WriteLine($"{input}: {sResult}");
            }
        }
    }
}

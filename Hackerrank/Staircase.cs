using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.Hackerrank
{
    // Source: https://www.hackerrank.com/challenges/staircase/problem?isFullScreen=true
    public static class Staircase
    {
        public static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++) { Console.Write(" "); }
                for (int k = 1; k <= i; k++) { Console.Write("#"); }
                Console.WriteLine();
            }
        }
    }
}

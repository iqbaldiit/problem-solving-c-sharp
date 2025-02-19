using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.HashMap
{
    // Source: https://leetcode.com/problems/equal-row-and-column-pairs/solutions/6440859/best-simple-solution-beats-59-runtime-90-rmy9/
    public static class EqualRowColumnPairs
    {
        /*
         Given a 0-indexed n x n integer matrix grid, return the number of pairs (ri, cj) 
         such that row ri and column cj are equal.
         A row and column pair is considered equal if they contain the same elements in 
         the same order (i.e., an equal array).



        Example 1:


        Input: grid = [[3,2,1],[1,7,6],[2,7,7]]
        Output: 1
        Explanation: There is 1 equal row and column pair:
        - (Row 2, Column 1): [2,7,7]
        Example 2:


        Input: grid = [[3,1,2,2],[1,4,4,5],[2,4,2,2],[2,4,2,2]]
        Output: 3
        Explanation: There are 3 equal row and column pairs:
        - (Row 0, Column 0): [3,1,2,2]
        - (Row 2, Column 2): [2,4,2,2]
        - (Row 3, Column 2): [2,4,2,2]


        Constraints:

        n == grid.length == grid[i].length
        1 <= n <= 200
        1 <= grid[i][j] <= 105
         */
        static int EqualPairs(int[][] grid)
        {
            {
                int n = grid.Length;
                int count = 0;

                for (int i = 0; i < n; i++) //For Traverse Horizontally (Column)
                {
                    for (int j = 0; j < n; j++) // For traversing Horizontally (Column)
                    {
                        bool isEqual = true;
                        for (int k = 0; k < n; k++) // For Traversing Vertically (Rows)
                        {
                            // Matching rows with each column
                            if (grid[i][k] != grid[k][j])
                            {
                                isEqual = false;
                                break;
                            }
                        }
                        if (isEqual)
                        {
                            count++;
                        }
                    }
                }

                return count;
            }
        }
        public static void Execute()
        {
            int[][] grid1 = {
            new int[] {3, 2, 1},
            new int[] {1, 7, 6},
            new int[] {2, 7, 7}
        };
            // Example 2
            int[][] grid2 = {
            new int[] {3, 1, 2, 2},
            new int[] {1, 4, 4, 5},
            new int[] {2, 4, 2, 2},
            new int[] {2, 4, 2, 2}
        };
            Console.WriteLine(EqualPairs(grid1));
            //Console.WriteLine(EqualPairs(grid2));            
        }
    }

}

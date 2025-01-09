using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.Hackerrank
{
    public static class DiagonalDifference
    {
        public static int diagonalSum(int[,] matrix)
        {
            int diagonalSum = 0;
            int n=matrix.GetLength(0); // assuming squar dimention
            int nPrimarySum = 0;
            int nSecondarySum = 0;

            ////Approach 1 (using loop)
            //for (int i = 0; i < n; i++) { nPrimarySum += matrix[i, i]; }// sum of primary values
            //for (int i = 0; i < n; i++) { nPrimarySum += matrix[i, n-1-i]; }// sum of secondary values            

            //Approach 2 (using LINQ)
            nPrimarySum = Enumerable.Range(0,n).Select(i => matrix[i,i]).ToArray().Sum();
            nSecondarySum=Enumerable.Range(0,n).Select(i=>matrix[i,n-1-i]).ToArray().Sum();

            diagonalSum = nPrimarySum + nSecondarySum;
            return diagonalSum;
        }
        public static int diagonalDifference(int[,] matrix)
        {
            int nDiagonalDiff = 0;
            int n = matrix.GetLength(0); // assuming squar dimention
            int nPrimarySum = 0;
            int nSecondarySum = 0;

            //Approach 1 (using loop)
            for (int i = 0; i < n; i++) { nPrimarySum += matrix[i, i]; }// sum of primary values
            for (int i = 0; i < n; i++) { nPrimarySum += matrix[i, n - 1 - i]; }// sum of secondary values            

            ////Approach 2 (using LINQ)
            //nPrimarySum = Enumerable.Range(0, n).Select(i => matrix[i, i]).ToArray().Sum();
            //nSecondarySum = Enumerable.Range(0, n).Select(i => matrix[i, n - 1 - i]).ToArray().Sum();


            nDiagonalDiff = Math.Abs(nPrimarySum - nSecondarySum);
            return nDiagonalDiff;
        }

        public static int diagonalSumList(List<List<int>> arr)
        {
            int diagonalSum = 0;
            int n = arr.Count; // assuming squar dimention
            int nPrimarySum = 0;
            int nSecondarySum = 0;

            ////Approach 1 (using loop)
            //for (int i = 0; i < n; i++) { nPrimarySum += arr[i][i]; }// sum of primary values
            //for (int i = 0; i < n; i++) { nPrimarySum += arr[i][n-1-i]; }// sum of secondary values            

            //Approach 2 (using LINQ)
            nPrimarySum = Enumerable.Range(0, n).Select(i => arr[i][i]).ToArray().Sum();
            nSecondarySum = Enumerable.Range(0, n).Select(i => arr[i][n-1-i]).ToArray().Sum();

            diagonalSum = nPrimarySum + nSecondarySum;
            return diagonalSum;
        }

        public static int diagonalDifferenceList(List<List<int>> arr)
        {
            int diagonalSum = 0;
            int n = arr.Count; // assuming squar dimention
            int nPrimarySum = 0;
            int nSecondarySum = 0;

            ////Approach 1 (using loop)
            //for (int i = 0; i < n; i++) { nPrimarySum += arr[i][i]; }// sum of primary values
            //for (int i = 0; i < n; i++) { nPrimarySum += arr[i][n-1-i]; }// sum of secondary values            

            //Approach 2 (using LINQ)
            nPrimarySum = Enumerable.Range(0, n).Select(i => arr[i][i]).ToArray().Sum();
            nSecondarySum = Enumerable.Range(0, n).Select(i => arr[i][n - 1 - i]).ToArray().Sum();

            diagonalSum = nPrimarySum - nSecondarySum;
            return Math.Abs(diagonalSum);
        }

        public static void ExecuteSum()
        {
            int[,] input = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
            var output = diagonalSum(input);
            Console.WriteLine(output);
        }

        public static void ExecuteDifference()
        {
            int[,] input = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
            var output = diagonalSum(input);
            Console.WriteLine(output);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.Hackerrank
{
    public static class Triplet
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> ab = [];
            var aPoint = 0;
            var bPoint = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i]) aPoint++;
                if (a[i] < b[i]) bPoint++;
            }
            ab = [aPoint, bPoint];
            return ab;
        }

        public static void Execute()
        {
            List<int> a = [3,4,5];
            List<int> b = [3, 6, 5];
            var ab=compareTriplets(a, b);
            ab.ForEach(Console.WriteLine);            
        }
    }


}

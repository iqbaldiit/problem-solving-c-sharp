using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.Hackerrank
{
    public static class BigSum
    {
        public static long aVeryBigSum(List<long> ar)
        {
            long nResult = 0;
            ////Approach 1            
            //foreach (long v in ar)
            //{
            //    nResult = nResult + v;
            //}

            //Approach 2 
            nResult= ar.Sum();
            return nResult;
        }

        public static void Execute()
        {
            List<long> input = [1000000001, 1000000002, 1000000003, 1000000004, 1000000005];
  
            var output = aVeryBigSum(input);
            Console.WriteLine(output);
        }
    }
}

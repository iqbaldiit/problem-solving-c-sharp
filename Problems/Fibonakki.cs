using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.Problems
{
    public static class Fibonakki
    {
        // Fibonakki Series By recursive
        
        public static void fibbonakki(int val1, int val2)
        {
            int nCount = 2;
            if (nCount <= 19)
            {
                var fibo = val1 + val2;
                System.Console.WriteLine(fibo);
                nCount++;
                val1 = val2;
                val2 = fibo;
                fibbonakki(val1, val2);
            }
            else { return; }
        }

        // Fibonakki Series By Loop
        public static void Run()
        {            
            var val1 = 0;
            var val2 = 1;
            System.Console.WriteLine(val1);
            System.Console.WriteLine(val2);

            for (var i = 0; i < 18; i++)
            {
                var fibo = val2 + val1;
                System.Console.WriteLine(fibo);
                val1 = val2;
                val2 = fibo;
            }
            fibbonakki(0, 1);
        }
    }
}

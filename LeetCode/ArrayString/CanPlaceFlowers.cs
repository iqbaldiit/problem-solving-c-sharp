using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.ArrayString
{
    //source: https://leetcode.com/problems/can-place-flowers/solutions/6331046/simple-best-solution-by-iqbaldiit-oey3/
    /*
        You have a long flowerbed in which some of the plots are planted, and some are not. However, 
        flowers cannot be planted in adjacent plots.

        Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, 
        and an integer n, return true if n new flowers can be planted in the flowerbed without violating 
        the no-adjacent-flowers rule and false otherwise. 

        Example 1:

        Input: flowerbed = [1,0,0,0,1], n = 1
        Output: true
        Example 2:

        Input: flowerbed = [1,0,0,0,1], n = 2
        Output: false
 

        Constraints:

        1 <= flowerbed.length <= 2 * 104
        flowerbed[i] is 0 or 1.
        There are no two adjacent flowers in flowerbed.
        0 <= n <= flowerbed.length
     */
    public static class CanPlaceFlowers
    {
        /*
            Input: flowerbed = [1, 0, 0, 0, 1], and n = 1 (Number of flowers)
            Output: true   
            Explanation: It means You can plant 1 flower in the middle position (index 2), resulting in [1, 0, 1, 0, 1]. 
                         The flower where you want to plant, the previous and next must be blanked.
         */
        private static bool Plant(int[] flowerbed,  int n)
        {
            int nFlowerPlanted = 0;
            int nNumberOfExistingPlace = flowerbed.Length;

            for (int i = 0; i< nNumberOfExistingPlace; i++)
            {
                if (flowerbed[i] == 0)
                {
                    var bPreviousPlace = (i == 0) ? 0 : flowerbed[i - 1]; // check in the previous place is first or, flower planted or not
                    //Check the next place, flower planted or not
                    var bNextPlace = (i == nNumberOfExistingPlace - 1) ? 0 : flowerbed[i + 1];

                    if (bPreviousPlace == 0 && bNextPlace == 0)
                    {
                        flowerbed[i] = 1;
                        nFlowerPlanted++;
                        i++;
                    }           
                }
            }

            return (nFlowerPlanted>=n);
        }

        public static void Execute()
        {
            //inputs
            int[] flowerbed = [1, 0, 0, 0, 1, 0, 0];
            int n = 2;

            //Output--> Boolean (True/False)
            Console.WriteLine(Plant(flowerbed,n));
        }
    }

}

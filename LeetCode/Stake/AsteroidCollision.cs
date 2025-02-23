using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm.LeetCode.Stake
{
    public static class AsteroidCollision
    {
        /*
            We are given an array asteroids of integers representing asteroids in a row. The indices of the asteriod in the array represent their relative position in space.

            For each asteroid, the absolute value represents its size, and the sign represents its direction (positive meaning right, negative meaning left). Each asteroid moves at the same speed.

            Find out the state of the asteroids after all collisions. If two asteroids meet, the smaller one will explode. If both are the same size, both will explode. Two asteroids moving in the same direction will never meet.

 

            Example 1:

            Input: asteroids = [5,10,-5]
            Output: [5,10]
            Explanation: The 10 and -5 collide resulting in 10. The 5 and 10 never collide.
            Example 2:

            Input: asteroids = [8,-8]
            Output: []
            Explanation: The 8 and -8 collide exploding each other.
            Example 3:

            Input: asteroids = [10,2,-5]
            Output: [10]
            Explanation: The 2 and -5 collide resulting in -5. The 10 and -5 collide resulting in 10.
          
         */
        static int[] AsteroCollision(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();

            foreach (int asteroid in asteroids)
            {
                bool exploded = false;

                while (stack.Count > 0 && asteroid < 0 && stack.Peek() > 0)
                {
                    int top = stack.Peek();
                    if (Math.Abs(asteroid) > top)
                    {
                        stack.Pop();
                    }
                    else if (Math.Abs(asteroid) == top)
                    {
                        stack.Pop();
                        exploded = true;
                        break;
                    }
                    else
                    {
                        exploded = true;
                        break;
                    }
                }

                if (!exploded)
                {
                    stack.Push(asteroid);
                }
            }

            int[] result = stack.ToArray();
            Array.Reverse(result);
            return result;
        }
        public static void Execute()
        {
            Console.WriteLine("["+string.Join(" ",AsteroCollision([5, 10, -5]).ToArray())+"]");
            Console.WriteLine("["+string.Join(" ", AsteroCollision([8, -8]).ToArray()) + "]");
            Console.WriteLine("["+string.Join(" ", AsteroCollision([10, 2, -5]).ToArray()) + "]");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Arrays
{
    //https://leetcode.com/problems/jump-game-iii/
    public class JumpGame3
    {
        //Solution based off of discussion post:
        //https://leetcode.com/problems/jump-game-iii/discuss/465602/JavaC%2B%2BPython-1-Line-Recursion
        public bool CanReach(int[] arr, int start)
        {
            if (start >= 0 && start < arr.Length && arr[start] >= 0)
            {
                arr[start] = -arr[start];
                return arr[start] == 0 || CanReach(arr, start + arr[start]) || CanReach(arr, start - arr[start]);
            }
            return false;
        }
    }
}

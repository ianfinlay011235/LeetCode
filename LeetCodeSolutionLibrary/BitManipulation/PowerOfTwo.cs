using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.BitManipulation
{
    //https://leetcode.com/problems/power-of-two/
    public class PowerOfTwo
    {
        public bool IsPowerOfTwo(int n)
        {
            return Math.Log2(n) % 1 == 0;
        }

        //https://leetcode.com/problems/power-of-two/discuss/63974/Using-nand(n-1)-trick
        public bool BitManipulation_IsPowerOfTwo(int n)
        {
            return ((n & (n - 1)) == 0);
        }
    }
}

using System;

namespace LeetCodeLibrary.Sums
{
    //https://leetcode.com/problems/arranging-coins/
    public class ArrangingCoins
    {
        public int ArrangeCoins(int n) => (int)(Math.Sqrt(2 * (double)n + 0.25) - 0.5);
    }
}

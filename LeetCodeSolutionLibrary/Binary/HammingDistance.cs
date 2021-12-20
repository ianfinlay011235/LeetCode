using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Binary
{
    public class HammingDistance
    {
        //https://leetcode.com/problems/hamming-distance/
        public int GetHammingDistance(int x, int y)
        {
            string xBin = Convert.ToString(x, 2).PadLeft(31, '0');
            string yBin = Convert.ToString(y, 2).PadLeft(31, '0');

            int count = 0;
            for (int i = 0; i < 31; i++)
            {
                if (xBin[i] != yBin[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}

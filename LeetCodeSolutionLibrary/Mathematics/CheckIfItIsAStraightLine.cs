using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Mathematics
{
    //Problem:
    //https://leetcode.com/problems/check-if-it-is-a-straight-line/

    public class CheckIfItIsAStraightLine
    {
        /* 
         * Time Complexity: O(n)
         * Space Complexity: O(1)
         * 
         * n = length of coordinates
         */
        public bool CheckStraightLine(int[][] coordinates)
        {
            if (coordinates.Length == 2) return true;

            // Slope Formula:
            // m = (y2 - y1) / (x2 - x1)
            double m = (coordinates[1][0] - coordinates[0][0]) / (coordinates[1][1] - coordinates[0][1]);

            for (int i = 2; i < coordinates.Length; i++)
            {
                int mNew = (coordinates[i][0] - coordinates[0][0]) / (coordinates[i][1] - coordinates[0][1]);

                //If the slope is different between any 3 points, it is not a straight line
                if (mNew != m) return false;
            }

            return true;
        }
    }
}

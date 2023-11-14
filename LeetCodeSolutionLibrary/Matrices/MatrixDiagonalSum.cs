using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Matrices
{
    //https://leetcode.com/problems/matrix-diagonal-sum/

    public class MatrixDiagonalSum
    {
        /*
         * Time Complexity: O(n)
         * Space Complexity: O(1)
         *  -Where n is the size of mat
         */
        public int DiagonalSum(int[][] mat)
        {
            int sum = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                sum += mat[i][i];
                sum += mat[i][mat[i].Length - 1 - i];
            }
            if (mat.Length % 2 == 1) sum -= mat[mat.Length / 2][mat.Length / 2];
            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Matrices
{
    //https://leetcode.com/problems/spiral-matrix-ii/

    public class SpiralMatrix2
    {
        /*
         * Time Complexity: O(n)
         * Space Complexity: O(1)
         */
        public int[][] GenerateMatrix(int n)
        {
            if (n == 1) return new int[][] { new int[] { 1 } };

            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }

            int top = 0;
            int right = n - 1;
            int bottom = n - 1;
            int left = 0;
            int current = 1;

            while (left <= right && top <= bottom)
            {
                //Top
                for (int i = left; i <= right; i++)
                {
                    matrix[top][i] = current;
                    current++;
                }
                top++;

                //Right
                for (int i = top; i <= bottom; i++)
                {
                    matrix[i][right] = current;
                    current++;
                }
                right--;

                //Bottom
                for (int i = right; i >= left; i--)
                {
                    matrix[bottom][i] = current++;
                }
                bottom--;

                //Left
                for (int i = bottom; i >= top; i--)
                {
                    matrix[i][left] = current++;
                }
                left++;
            }
            return matrix;
        }
    }
}

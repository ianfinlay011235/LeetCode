using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Matrices
{
    //https://leetcode.com/problems/kth-smallest-number-in-multiplication-table/
    public class KthSmallestNumberInMultiplicationTable
    {
        public int FindKthNumber(int m, int n, int k)
        {
            List<int> table = new List<int>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    table.Add((i + 1) * (j + 1));
                }
            }
            table.Sort();
            return table[k - 1];
        }
    }
}

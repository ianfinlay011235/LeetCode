using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.Matrices
{
    //https://leetcode.com/problems/interval-list-intersections/
    //Discussion to improve solution: https://leetcode.com/problems/interval-list-intersections/discuss/647482/Python-Two-Pointer-Approach-%2B-Thinking-Process-Diagrams
    public class IntervalListIntersections
    {
        public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
        {
            List<int[]> list = new List<int[]>();
            int firstIndex = 0, secondIndex = 0;
            while (firstIndex < firstList.Length && secondIndex < secondList.Length)
            {
                if (firstList[firstIndex][0] > secondList[secondIndex][1])
                {
                    secondIndex++;
                    continue;
                }
                else if (secondList[secondIndex][0] > firstList[firstIndex][1])
                {
                    firstIndex++;
                    continue;
                }
                int lb = firstList[firstIndex][0] < secondList[secondIndex][0] ? secondList[secondIndex][0] : firstList[firstIndex][0];
                int ub = firstList[firstIndex][1] < secondList[secondIndex][1] ? firstList[firstIndex++][1] : secondList[secondIndex++][1];
                list.Add(new int[] { lb, ub });
            }
            return list.ToArray();
        }
    }
}

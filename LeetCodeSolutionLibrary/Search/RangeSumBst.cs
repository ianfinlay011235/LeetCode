using LeetCodeLibrary.DataStructures.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Search
{
    //https://leetcode.com/problems/range-sum-of-bst/description/

    public class RangeSumBst
    {
        public int RangeSum(TreeNode root, int low, int high)
        {
            if (root == null) return 0;

            if (root.Val < low)
            {
                return RangeSum(root.Right, low, high);
            }
            
            if (root.Val > high)
            {
                return RangeSum(root.Left, low, high);
            }
            
            return root.Val + RangeSum(root.Left, low, high) + RangeSum(root.Right, low, high);
        }
    }
}

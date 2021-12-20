using LeetCodeLibrary.DataStructures.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.BinaryTrees
{
    //https://leetcode.com/problems/range-sum-of-bst/
    public class RangeSumOfBst
    {
        public int RangeSumBst(TreeNode root, int low, int high)
        {
            if (root == null)
            {
                return 0;
            }
            if (root.Val > high)
            {
                return RangeSumBst(root.Left, low, high);
            }
            if (root.Val < low)
            {
                return RangeSumBst(root.Right, low, high);
            }
            return root.Val + RangeSumBst(root.Left, low, high) + RangeSumBst(root.Right, low, high);
        }
    }
}

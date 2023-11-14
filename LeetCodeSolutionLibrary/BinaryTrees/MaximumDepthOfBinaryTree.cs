using LeetCodeLibrary.DataStructures.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.BinaryTrees
{
    //https://leetcode.com/problems/maximum-depth-of-binary-tree/
    public class MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            return System.Math.Max(MaxDepth(root.Left), MaxDepth(root.Right)) + 1;
        }
    }
}

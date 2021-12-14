using LeetCodeLibrary.DataStructures.Tree;
using System;

namespace LeetCodeLibrary.BinaryTrees
{
    //https://leetcode.com/problems/binary-tree-tilt/
    public class BinaryTreeTilt
    {
        public int FindTilt(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return Math.Abs(TreeSum(root.Left) - TreeSum(root.Right)) + FindTilt(root.Left) + FindTilt(root.Right);
        }

        public int TreeSum(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return root.Val + TreeSum(root.Left) + TreeSum(root.Right);
        }
    }
}

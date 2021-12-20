using LeetCodeLibrary.DataStructures.Tree;

namespace LeetCodeLibrary.BinaryTrees
{
    //https://leetcode.com/problems/sum-of-left-leaves/
    public class SumOfLeftLeaveNumbers
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null) 
            {
                return 0;
            } 
            else if (root.Left != null && root.Left.Left == null && root.Left.Right == null)
            {
                return root.Left.Val + SumOfLeftLeaves(root.Right);
            }
            else
            {
                return SumOfLeftLeaves(root.Left) + SumOfLeftLeaves(root.Right);
            }
        }
    }
}

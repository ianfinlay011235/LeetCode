using LeetCodeLibrary.DataStructures.Tree;

namespace LeetCodeLibrary.BinaryTrees
{
    //https://leetcode.com/problems/path-sum/
    public class PathSum
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            if (root.Left == null && root.Right == null) return targetSum - root.Val == 0;
            return  HasPathSum(root.Left, targetSum - root.Val) || HasPathSum(root.Right, targetSum - root.Val);
        }
    }
}

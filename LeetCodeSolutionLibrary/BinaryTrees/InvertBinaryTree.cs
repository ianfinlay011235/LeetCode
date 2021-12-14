using LeetCodeLibrary.DataStructures.Tree;

namespace LeetCodeLibrary.BinaryTrees
{
    //https://leetcode.com/problems/invert-binary-tree/
    public class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return root;
            TreeNode invertedRoot = new TreeNode(root.Val);
            invertedRoot.Left = InvertTree(root.Right);
            invertedRoot.Right = InvertTree(root.Left);
            return invertedRoot;
        }
    }
}

using LeetCodeLibrary.DataStructures.Tree;

namespace LeetCodeLibrary.BinaryTrees
{
    //https://leetcode.com/problems/sum-root-to-leaf-numbers/
    public class SumRootToLeafNumbers
    {
        public int SumNumbers(TreeNode root)
        {
            if (root == null) return 0;
            return SumNumbersHelper(root, 0);
        }

        public int SumNumbersHelper(TreeNode node, int curVal)
        {
            if (node == null) return 0;

            curVal = curVal * 10 + node.Val;
            if (node.Left == null && node.Right == null) return curVal;
            return SumNumbersHelper(node.Left, curVal) + SumNumbersHelper(node.Right, curVal);
        }
    }
}

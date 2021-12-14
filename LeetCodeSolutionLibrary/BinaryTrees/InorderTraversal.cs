using LeetCodeLibrary.DataStructures.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary.BinaryTrees
{
    //https://leetcode.com/problems/binary-tree-inorder-traversal/
    public class InorderTraversal
    {
        public IList<int> Traverse(TreeNode root)
        {
            List<int> result = new List<int>();
            if (root != null)
            {
                result.AddRange(Traverse(root.Left));
                result.Add(root.Val);
                result.AddRange(Traverse(root.Right));
            }
            return result;
        }
    }
}

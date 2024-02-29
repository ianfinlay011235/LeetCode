using LeetCodeLibrary.DataStructures.Tree;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Tree
{
	//https://leetcode.com/problems/find-bottom-left-tree-value

	public class FindBottomLeftTreeValue
	{
		/*
		 * Time Complexity: O(n) where n is the number of nodes in the tree
		 * Space Complexity: O(m) where m is the maximum number of nodes at any level in the tree
		 */
		public int FindBottomLeftValue(TreeNode root)
		{
			Queue<TreeNode> queue = new Queue<TreeNode>();
			queue.Enqueue(root);

			int bottomLeft = root.Val;

            while (queue.Count > 0)
            {
				TreeNode node = queue.Dequeue();

				bottomLeft = node.Val;

                if (node.Right != null)
                {
					queue.Enqueue(node.Right);
                }
                if (node.Left != null)
                {
					queue.Enqueue(node.Left);
                }
            }

			return bottomLeft;
		}
	}
}
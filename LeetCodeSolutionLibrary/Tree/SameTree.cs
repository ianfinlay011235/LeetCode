using LeetCodeLibrary.DataStructures.Tree;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Tree
{
	//https://leetcode.com/problems/same-tree

	public class SameTree
	{
		/*
		 * Time Complexity: O(n) where n is the number of nodes in the tree
		 * Space Complexity: O(1)
		 */
		public bool IsSameTree(TreeNode p, TreeNode q)
		{
			if (p == null && q == null) return true;

			if ((p == null && q != null) || (p != null && q == null) || p.Val != q.Val) return false;

			return IsSameTree(p.Left, q.Left) && IsSameTree(p.Right, q.Right);
		}
	}
}
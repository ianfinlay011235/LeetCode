using LeetCodeLibrary.DataStructures.Tree;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.BinaryTrees
{
	//https://leetcode.com/problems/pseudo-palindromic-paths-in-a-binary-tree/description

	public class PseudoPalindromicPathsInABinaryTree
	{
		/*
		 * Time Complexity: O()
		 * Space Complexity: O()
		 */
		public int PseudoPalindromicPaths(TreeNode root)
		{
			bool?[] parities = Enumerable.Repeat<bool?>(null, 10).ToArray();
			return PseudoPalindromicPaths(root, parities);
		}

		public int PseudoPalindromicPaths(TreeNode root, bool?[] parities)
		{
			if (root == null) return 0;

			//First time value is encountered
            if (parities[root.Val] == null) parities[root.Val] = true;

			//Flip parity of current value
			parities[root.Val] = !parities[root.Val];

			//Node is a leaf - check for pseudo-palindrom and return
			if (root.Left == null && root.Right == null)
			{
				//A path is a pseudo-palindrom if there is less than or equal to 1
				//value that occurs an odd number of times
				bool isPseudoPalindromic = parities.Where(k => k != null && k == false).Count() <= 1;

				return isPseudoPalindromic ? 1 : 0;
			}

			bool?[] leftParity = null;
            if (root.Left != null)
            {
				leftParity = new bool?[parities.Length];
				Array.Copy(parities, leftParity, parities.Length);

            }

			bool?[] rightParity = null;
            if (root.Right != null)
            {
				rightParity = new bool?[parities.Length];
				Array.Copy(parities, rightParity, parities.Length);
            }

			return PseudoPalindromicPaths(root.Left, leftParity) + PseudoPalindromicPaths(root.Right, rightParity);
		}
    }
}
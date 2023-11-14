using LeetCodeLibrary.DataStructures.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.BinaryTrees
{
    //https://leetcode.com/problems/maximum-width-of-binary-tree/

    public class MaximumWidthOfBinaryTree
    {
        /*
         * Time Complexity: O(N)
         * Space Complexity: O(N)
         *  -N is the number of nodes in the tree
         */

        public int WidthOfBinaryTree(TreeNode root)
        {
            if (root == null) return 0;

            var queue = new Queue<KeyValuePair<TreeNode, int>>();
            queue.Enqueue(new KeyValuePair<TreeNode, int>(root, 0));
            int maxWidth = 0;

            while (queue.Count > 0)
            {
                int levelLength = queue.Count;
                int levelStart = queue.Peek().Value;
                int index = 0;

                for (int i = 0; i < levelLength; i++)
                {
                    var pair = queue.Dequeue();
                    TreeNode node = pair.Key;
                    index = pair.Value;

                    if (node.Left != null)
                    {
                        queue.Enqueue(new KeyValuePair<TreeNode, int>(node.Left, index * 2));
                    }
                    if (node.Right != null)
                    {
                        queue.Enqueue(new KeyValuePair<TreeNode, int>(node.Right, index * 2 + 1));
                    }
                }

                maxWidth = System.Math.Max(maxWidth, index - levelStart + 1);
            }

            return maxWidth;
        }
    }
}

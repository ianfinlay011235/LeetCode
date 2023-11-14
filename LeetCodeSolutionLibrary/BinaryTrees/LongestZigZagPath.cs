using LeetCodeLibrary.DataStructures.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.BinaryTrees
{
    //https://leetcode.com/problems/longest-zigzag-path-in-a-binary-tree/

    public class LongestZigZagPath
    {
        /*
         * Time Complexity: O(N)
         * Space Complexity: O(N)
         *  -N is the number of nodes
         */

        private int _maxLength = 0;

        public int LongestZigZag(TreeNode root)
        {
            LongestZigZagHelper(root.Left, Direction.Left, 1);
            LongestZigZagHelper(root.Right, Direction.Right, 1);
            return _maxLength;
        }

        public void LongestZigZagHelper(TreeNode root, Direction dir, int currentLength)
        {
            if (root == null) return;

            _maxLength = System.Math.Max(_maxLength, currentLength);

            if (dir == Direction.Left)
            {
                LongestZigZagHelper(root.Left, Direction.Left, 1);
                LongestZigZagHelper(root.Right, Direction.Right, currentLength + 1);
            }
            else //dir == Direction.Right
            {
                LongestZigZagHelper(root.Left, Direction.Left, currentLength + 1);
                LongestZigZagHelper(root.Right, Direction.Right, 1);            
            }
        }

        public enum Direction
        {
            Left,
            Right
        }
    }
}

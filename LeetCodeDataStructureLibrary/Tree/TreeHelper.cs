using System;
using System.Collections.Generic;

namespace LeetCodeLibrary.DataStructures.Tree
{
    public static class TreeHelper
    {
        //Builder for complete binary tree
        public static TreeNode BuildTree(this int[] array)
        {
            TreeNode root = new TreeNode();
            root = InsertLevelOrder(array, root, 0);
            return root;
        }

        //Level Order Methods (Breadth First)
        public static TreeNode InsertLevelOrder(int[] array, TreeNode root, int index)
        {
            //Base case for recursion
            if (index < array.Length)
            {
                TreeNode temp = new TreeNode(array[index]);
                root = temp;

                //Insert left child
                root.Left = InsertLevelOrder(array, root.Left, 2 * index + 1);

                //Insert right child
                root.Right = InsertLevelOrder(array, root.Right, 2 * index + 2);
            }
            return root;
        }

        //Builder for incomplete binary tree
        //Code adapted from Steven's answer:
        //https://stackoverflow.com/questions/37941318/how-to-build-an-incomplete-binary-tree-from-array-representation
        public static TreeNode BuildTree(this int?[] array)
        {
            if (array == null || array.Length == 0)
            {
                return null;
            }

            Queue<TreeNode> treeNodeQueue = new Queue<TreeNode>();
            Queue<int?> integerQueue = new Queue<int?>();
            for (int i = 0; i < array.Length; i++)
            {
                integerQueue.Enqueue(array[i]);
            }

            TreeNode treeNode = new TreeNode((int)integerQueue.Dequeue());
            treeNodeQueue.Enqueue(treeNode);

            while (integerQueue.Count > 0)
            {
                int? leftVal = integerQueue.Count == 0 ? null : integerQueue.Dequeue();
                int? rightVal = integerQueue.Count == 0 ? null : integerQueue.Dequeue();
                TreeNode current = treeNodeQueue.Dequeue();
                if (leftVal != null)
                {
                    TreeNode left = new TreeNode((int)leftVal);
                    current.Left = left;
                    treeNodeQueue.Enqueue(left);
                }
                if (rightVal != null)
                {
                    TreeNode right = new TreeNode((int)rightVal);
                    current.Right = right;
                    treeNodeQueue.Enqueue(right);
                }
            }
            return treeNode;
        }

        //To Array
        public static int?[] ToLevelOrderArray(this TreeNode root)
        {
            int?[] output = new int?[root.Size()];
            int height = root.Height();
            int index = 0;
            for (int level = 1; level <= height; level++)
            {
                AddCurrentLevelToArray(root, level, output, ref index);
            }
            return output;
        }

        private static void AddCurrentLevelToArray(TreeNode root, int level, int?[] arr, ref int index)
        {
            if (root == null) return;
            if (level == 1) arr[index++] = root.Val;
            else if (level > 1)
            {
                AddCurrentLevelToArray(root.Left, level - 1, arr, ref index);
                AddCurrentLevelToArray(root.Right, level - 1, arr, ref index);
            }
        }

        //Tree Properties
        public static int Size(this TreeNode root)
        {
            if (root == null) return 0;
            return root.Left.Size() + root.Right.Size() + 1;
        }

        public static int Height(this TreeNode root)
        {
            if (root == null) return 0;
            return Math.Max(root.Left.Height(), root.Right.Height()) + 1;
        }
    }
}

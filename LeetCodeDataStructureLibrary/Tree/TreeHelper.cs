using System;

namespace LeetCodeLibrary.DataStructures.Tree
{
    public static class TreeHelper
    {
        //Builders
        public static TreeNode BuildTree(this int[] array)
        {
            TreeNode root = new TreeNode();
            root = InsertLevelOrder(array, root, 0);
            return root;
        }

        //This method only works for creating complete binary trees
        //TODO: Fix to acommodate non-complete binary trees
        public static TreeNode BuildTree(this int?[] array)
        {
            if (array.Length == 0) return null;
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

        public static TreeNode InsertLevelOrder(int?[] array, TreeNode root, int index)
        {
            //Base case for recursion
            if (index < array.Length && array[index] != null)
            {
                TreeNode temp = new TreeNode((int)array[(int)index]);
                root = temp;

                //Insert left child
                root.Left = InsertLevelOrder(array, root.Left, 2 * index + 1);

                //Insert right child
                root.Right = InsertLevelOrder(array, root.Right, 2 * index + 2);
            }
            return root;
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

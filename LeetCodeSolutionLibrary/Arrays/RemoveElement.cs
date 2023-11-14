namespace LeetCodeLibrary.Arrays
{
    //https://leetcode.com/problems/remove-element/

    public class RemoveElement
    {
        /*
         * Time Complexity: O(N)
         *  -N is the size of nums
         *  
         * Space Complexity: O(1)
         *  -The removal of elements occurs "in place"
         */

        public int Remove(int[] nums, int val)
        {
            int i = 0;
            int n = nums.Length;

            while (i < n)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[n - 1];
                    n--;
                }
                else
                {
                    i++;
                }
            }
            return n;
        }
    }
}

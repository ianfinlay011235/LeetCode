namespace LeetCodeLibrary.Arrays
{
    //https://leetcode.com/problems/remove-element/
    public class RemoveElement
    {
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

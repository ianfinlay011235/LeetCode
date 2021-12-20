namespace LeetCodeLibrary.Sorting
{
    //https://leetcode.com/problems/sort-colors/
    public class ColorSorter
    {
        //Red = 0
        //White = 1
        //Blue = 2
        //Sort by Red, White, then Blue
        public void SortColors(int[] nums)
        {
            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = index; j < nums.Length; j++)
                {
                    if (nums[j] == i)
                    {
                        int temp = nums[index];
                        nums[index] = nums[j];
                        nums[j] = temp;
                        index++;
                    }
                }
                if (index >= nums.Length) break;
            }
        }

        public void DutchPartitioningProblem()
        {
            //https://en.wikipedia.org/wiki/Dutch_national_flag_problem
        }
    }
}

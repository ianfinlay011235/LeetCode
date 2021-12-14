namespace LeetCodeLibrary.Sums
{
    //https://leetcode.com/problems/minimum-value-to-get-positive-step-by-step-sum/
    public class MinValueToGetPosSum
    {
        public int MinStartValue(int[] nums)
        {
            int startValue = 1;
            int curValue;

            while (true)
            {
                curValue = startValue;
                for (int i = 0; i < nums.Length; i++)
                {
                    curValue += nums[i];
                    if (curValue < 1)
                    {
                        startValue++;
                        break;
                    }
                    else if (i + 1 == nums.Length)
                    {
                        return startValue;
                    }
                }
            }
        }
    }
}

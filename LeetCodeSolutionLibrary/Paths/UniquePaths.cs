namespace LeetCodeLibrary.Paths
{
    //https://leetcode.com/problems/unique-paths/
    public class UniquePaths
    {
        public int GetUniquePaths(int m, int n)
        {
            return UniquePathHelper(m, n, 0, 0);
        }

        private int UniquePathHelper(int m, int n, int mIndex, int nIndex)
        {
            if (mIndex + 1 == m && nIndex + 1 == n)
            {
                return 1;
            }
            else if (mIndex + 1 == m)
            {
                return UniquePathHelper(m, n, mIndex, nIndex + 1);
            }
            else if (nIndex + 1 == n)
            {
                return UniquePathHelper(m, n, mIndex + 1, nIndex);
            }
            else
            {
                return UniquePathHelper(m, n, mIndex, nIndex + 1) + UniquePathHelper(m, n, mIndex + 1, nIndex);
            }
        }
    }
}

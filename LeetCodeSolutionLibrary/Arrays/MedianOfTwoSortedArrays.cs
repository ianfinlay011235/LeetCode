namespace LeetCodeLibrary.Arrays
{
    //https://leetcode.com/problems/median-of-two-sorted-arrays/
    public class MedianOfTwoSortedArrays
    {
        private int[] _nums1;
        private int[] _nums2;
        private int _mIndex = 0;
        private int _nIndex = 0;

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            _nums1 = nums1;
            _nums2 = nums2;

            int size = _nums1.Length + _nums2.Length;
            bool isEven = size % 2 == 0;
            int medianIndex = isEven ? (size / 2) - 1 : size / 2;

            while (_mIndex + _nIndex < medianIndex)
            {
                _ = GetNextVal();
            }

            return isEven ? (GetNextVal() + GetNextVal()) / 2 : GetNextVal();
        }

        private double GetNextVal()
        {
            if (_mIndex >= _nums1.Length)
            {
                return _nums2[_nIndex++];
            }
            else if (_nIndex >= _nums2.Length)
            {
                return _nums1[_mIndex++];
            }
            else if (_nums1[_mIndex] <= _nums2[_nIndex])
            {
                return _nums1[_mIndex++];
            }
            return _nums2[_nIndex++];
        }
    }
}

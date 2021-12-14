namespace LeetCodeLibrary.Strings
{
    //https://leetcode.com/problems/implement-strstr/
    public class ImplementStrStr
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0) return 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (i + j == haystack.Length) return -1;
                    if (needle[j] != haystack[i + j]) break;
                    if (j == needle.Length - 1) return i;
                }
            }
            return -1;
        }
    }
}

using System.Linq;

namespace LeetCodeLibrary.Strings
{
    public class ReverseWordsInAString
    {
        public string ReverseWords(string s)
        {
            var tokens = s.Split(" ").ToList();
            _ = tokens.RemoveAll(token => token == "");
            tokens.Reverse();
            return string.Join(" ", tokens);
        }
    }
}

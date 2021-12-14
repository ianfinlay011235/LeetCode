using System.Text.RegularExpressions;

namespace LeetCodeLibrary.Strings
{
    //https://leetcode.com/problems/number-of-valid-words-in-a-sentence/
    public class NumberOfValidWordsInASentence
    {
        public int CountValidWords(string sentence)
        {
            Regex regex = new Regex(@"^[a-z]*([a-z]*\-?[a-z]+)*[a-z]*[\!.,]?$");
            int count = 0;

            foreach (var token in sentence.Split(" "))
            {
                if (string.IsNullOrWhiteSpace(token) == false && regex.IsMatch(token))
                {
                    count++;
                }
            }

            return count;
        }
    }
}

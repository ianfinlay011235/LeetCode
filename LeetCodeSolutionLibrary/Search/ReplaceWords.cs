using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutionLibrary.Search
{
	//leetcode.com/problems/replace-words

	public class ReplaceWords
	{
		/*
		 * Time Complexity: O()
		 * Space Complexity: O()
		 */
		public string Replace(IList<string> dictionary, string sentence)
		{
			SortedDictionary<int, HashSet<string>> lengthDict = new();
			List<string> outputWords = new();

			//Build dictionary
            foreach (var word in dictionary)
			{
				if (!lengthDict.ContainsKey(word.Length))
                {
					lengthDict[word.Length] = new HashSet<string>();
                }

				lengthDict[word.Length].Add(word);
            }

			foreach (var word in sentence.Split(' '))
            {
				string outputWord = word;

                foreach (var key in lengthDict.Keys)
                {
                    if (word.Length <= key)
                    {
						break;
                    }
                    if (lengthDict[key].Contains(word.Substring(0, key)))
                    {
						outputWord = word.Substring(0, key);
						break;
                    }
                }

				outputWords.Add(outputWord);
            }

			return string.Join(' ', outputWords);
		}
	}
}
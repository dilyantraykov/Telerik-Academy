/*
Condition
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        int numberOfParagraphs = int.Parse(Console.ReadLine());
        var paragraphs = new List<string>();
        for (int i = 0; i < numberOfParagraphs; i++)
        {
            paragraphs.Add(Console.ReadLine());
        }

        var sortedParagraphs = new List<KeyValuePair<int, string>>();
        for (int i = 0; i < paragraphs.Count; i++)
        {
            paragraphs[i] = Regex.Replace(paragraphs[i], @"[,.\(\);\-!?]+", " ");
            paragraphs[i] = Regex.Replace(paragraphs[i], @"[ ]+", " ");
            string searchWord = @"\b" + word + @"\b";
            int relevanceIndex = Regex.Matches(paragraphs[i], searchWord, RegexOptions.IgnoreCase).Count;
            paragraphs[i] = Regex.Replace(paragraphs[i], searchWord, word.ToUpper(), RegexOptions.IgnoreCase);

            sortedParagraphs.Add(new KeyValuePair<int, string>(relevanceIndex, paragraphs[i].Trim()));
        }

        var lookupParagraphs = (Lookup<int, string>)sortedParagraphs.ToLookup(
                                             (item) => item.Key,
                                             (item) => item.Value
                                             );

        var sortedLookupParagraphs = lookupParagraphs.OrderByDescending(l => l.Key);

        foreach (var item in sortedLookupParagraphs)
        {
            foreach (var value in item)
            {
                Console.WriteLine(value);
            }
        }
    }
}

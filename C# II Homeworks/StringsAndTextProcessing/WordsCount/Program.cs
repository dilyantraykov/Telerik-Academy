/*
Problem 22. Words count

Write a program that reads a string from the console and lists all different words
in the string along with information how many times each word is found.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        MatchCollection words = Regex.Matches(input, @"\b\w+\b");

        Dictionary<string, int> dict = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (word.ToString() != string.Empty)
            {
                if (!dict.ContainsKey(word.ToString()))
                {
                    dict.Add(word.ToString(), 1);
                }
                else
                {
                    dict[word.ToString()]++;
                }
            }
        }

        Console.WriteLine(string.Join("\n", dict.Select(x => string.Format(@"{0} - {1}", x.Key, x.Value)).ToArray()));
    }
}

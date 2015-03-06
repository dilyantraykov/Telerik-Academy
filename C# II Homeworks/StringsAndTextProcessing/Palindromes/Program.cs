/*
Problem 20. Palindromes

Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
*/

using System;

class Program
{
    static void Main()
    {
        string text = "Here are some words: ABBA, baby, Lamal, potato, exe.";
        char[] chars = new[] { ' ', '!', ',', '?', '.', '-', ':', ';', '\'', '"' };
        string[] words = text.Split(chars, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            string reverse = "";
            for (int i = word.Length - 1; i >= 0; i--)
			{
			    reverse += word[i];
			}
            if (word.Length > 2 && word.ToUpper().Equals(reverse.ToUpper()))
            {
                Console.WriteLine(word);
            }
        }
    }
}

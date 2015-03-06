﻿/*
Problem 9. Forbidden words

We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
*/

using System;
using System.Text;

class Program
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        StringBuilder replacedText = new StringBuilder(text.Length);
        string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };
        replacedText.Append(text);
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            string astericks = string.Empty;
            for (int j = 0; j < forbiddenWords[i].Length; j++)
			{
			    astericks += '*';
			}
            replacedText.Replace(forbiddenWords[i], astericks);
        }
        Console.WriteLine(replacedText);
    }
}

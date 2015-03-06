/*
Problem 8. Extract sentences

Write a program that extracts from a given text all sentences containing given word.
Example:

The word is: in

The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

Consider that the sentences are separated by . and the words – by non-letter symbols.
*/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string[] sentences = text.Split('.');
        string word = "in";
        List<string> correctSentences = new List<string>();
        foreach (var sentence in sentences)
        {
            if (Regex.IsMatch(sentence, @"\b" + word + @"\b"))
            {
                Console.Write(sentence + ".");
            }
        }
        Console.WriteLine();
    }
}

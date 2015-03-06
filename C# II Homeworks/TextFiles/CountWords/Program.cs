/*
Problem 13. Count words

Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
Handle all possible exceptions in your methods.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        try
        {
            string[] badWords = { "potato", "tomato", "cucumber" };
            var wordsWriter = new StreamWriter("../../words.txt");
            for (int i = 0; i < badWords.Length; i++)
            {
                wordsWriter.WriteLine(badWords[i]);
            }
            wordsWriter.Close();

            var writer = new StreamWriter("../../test.txt");
            for (int i = 0; i < 99; i++)
            {
                writer.WriteLine("Mom brought home a tomato and a potato, a potato and a cucumber. I really hate tomatoes...");
            }
            writer.Close();

            var input = new StreamReader("../../test.txt");
            var output = new StreamWriter("../../result.txt");
            string text = input.ReadToEnd();
            string regex = @"\b(" + String.Join("|", File.ReadAllLines("../../words.txt")) + @")\b";
            MatchCollection words = Regex.Matches(text, regex);

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
            foreach (var item in dict.OrderBy(key => key.Value).Select(x => string.Format("{0} - {1}", x.Key, x.Value)))
            {
                output.WriteLine(item);
            }
            input.Close();
            output.Close();
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

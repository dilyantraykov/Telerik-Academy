/*
Problem 12. Remove words

Write a program that removes from a text file all words listed in given another text file.
Handle all possible exceptions in your methods.
*/

using System;
using System.IO;
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

            var writer = new StreamWriter("../../input.txt");
            for (int i = 0; i < 100; i++)
            {
                writer.WriteLine("Mom brought home a tomato, a potato and a cucumber. I really hate tomatoes...");
            }
            writer.Close();

            var input = new StreamReader("../../input.txt");
            var output = new StreamWriter("../../output.txt");
            string line = input.ReadLine();
            string regex = @"\b(" + String.Join("|", File.ReadAllLines("../../words.txt")) + @")\b";
            while(line != null)
            {
                output.WriteLine(Regex.Replace(line, regex, String.Empty));
                line = input.ReadLine();
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

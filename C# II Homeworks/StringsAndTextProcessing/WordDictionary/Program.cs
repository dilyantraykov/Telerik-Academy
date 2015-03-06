/*
Problem 14. Word dictionary

A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
Sample dictionary:

input	        output
.NET	        platform for applications from Microsoft
CLR	            managed execution environment for .NET
namespace	    hierarchical organization of classes
*/

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string dictionary = @".NET - platform for applications from Microsoft
CLR - managed execution environment for .NET
namespace - hierarchical organization of classes
Telerik - deliver more than expected
";

        string searchWord = Console.ReadLine();
        string regex = searchWord + @"(\s+?)\-(\s+?)(?<description>((.|\s)*?))\n";
        var matches = Regex.Matches(dictionary, regex, RegexOptions.IgnoreCase);

        if (matches.Count > 0)
        {
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups["description"]);
            }
        }
        else
        {
            Console.WriteLine("Word not found!");
        }
    }
}

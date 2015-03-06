/*
Problem 23. Series of letters

Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
Example:

input	                    output
aaaaabbbbbcdddeeeedssaa	    abcdedsa
*/

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";
        string regex = @"(?<letter>[A-Z])\1+";

        Console.WriteLine(Regex.Replace(text, regex, m => m.Groups["letter"].Value, RegexOptions.IgnoreCase));
    }
}

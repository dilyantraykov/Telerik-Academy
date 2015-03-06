/*
Problem 10. Unicode characters

Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
Example:

input	    output
Hi!	        \u0048\u0069\u0021
*/

using System;
using System.Text;

class Program
{
    static void Main()
    {
        string input = "Hi!";
        StringBuilder output = new StringBuilder(input.Length);
        for (int i = 0; i < input.Length; i++)
        {
            string formatString = @"\u" + String.Format("{0:X4}", (int)input[i]);
            output.Append(formatString);
        }
        Console.WriteLine(output);
    }
}

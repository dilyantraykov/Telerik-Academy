/*
Problem 1. StringBuilder.Substring

Implement an extension method Substring(int index, int length) for the class StringBuilder that returns
new StringBuilder and has the same functionality as Substring in the class String.
*/

using System;
using System.Text;

public static class StringBuilderSubstring
{
    public static StringBuilder Substring(this StringBuilder str, int startIndex, int length)
    {
        if (startIndex < 0 || startIndex >= str.Length)
        {
            throw new IndexOutOfRangeException();
        }

        if (length < 0)
        {
            throw new ArgumentException("Length must be greater than zero.");
        }

        if (startIndex + length >= str.Length)
        {
            throw new ArgumentException("The substring is too big.");
        }

        var result = new StringBuilder(length);
        for (int i = startIndex; i < startIndex + length; i++)
        {
            result.Append(str[i]);
        }
        return result;
    }

    static void Main()
    {
        var testStr = new StringBuilder();
        testStr.Append("This text is random!");
        Console.WriteLine(testStr.Substring(5, 4));
    }
}

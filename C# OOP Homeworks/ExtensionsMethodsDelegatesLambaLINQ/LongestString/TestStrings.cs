/*
Problem 17. Longest string

Write a program to return the string with maximum length from an array of strings.
Use LINQ.
*/

using System;
using System.Linq;

class TestStrings
{
    static void Main()
    {
        var strings = new[]
        {
            "This long string",
            "This string",
            "The looooongest string",
            "Just a long string"
        };

        Console.WriteLine(strings.OrderByDescending(str => str.Length).First());
    }
}

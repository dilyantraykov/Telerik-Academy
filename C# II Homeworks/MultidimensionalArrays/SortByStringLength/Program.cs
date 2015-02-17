/*
Problem 5. Sort by string length

You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
*/

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] array = { "somestring", "verylooongstring", "secondstring", "str", "longstring" };
        var sorted = array.OrderBy(x => x.Length);
        foreach (var item in sorted)
        {
            Console.WriteLine(item);
        }
    }
}

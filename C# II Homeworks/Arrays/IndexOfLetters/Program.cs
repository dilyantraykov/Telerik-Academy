/*
Problem 12. Index of letters

Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<char> letters = new List<char>();
        int start = 'a';
        int end = 'z';
        for (int i = start; i <= end; i++)
        {
            letters.Add((char)i); // a - 0 to z - 25
        }
        start = 'A';
        end = 'Z';
        for (int i = start; i <= end; i++)
        {
            letters.Add((char)i); // A - 26 to Z - 51
        }
        string input = Console.ReadLine();
        foreach (var letter in input)
        {
            int index = letters.FindIndex(x => x == letter);
            if (index != -1)
            {
                Console.Write(index + " ");
            }
            else
            {
                Console.WriteLine("Invalid letter!");
            }
        }
        Console.WriteLine();
    }
}

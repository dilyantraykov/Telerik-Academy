/*
Problem 24. Order words

Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
*/

using System;

class Program
{
    static void Main()
    {
        string list = "Football academy cOmputer friend game Ball";

        string[] words = list.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(words);

        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}


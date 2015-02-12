/*
Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).
*/

using System;

class Program
{
    static void Main()
    {
        // strings are arrays of chars
        Console.WriteLine("Enter string #1: ");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter string #2: ");
        string str2 = Console.ReadLine();
        // cut one of the strings, so that they're of equal length
        int length = str1.Length < str2.Length ? str1.Length : str2.Length;
        char sign = '>';
        // as it's not clear in the task, I'm comparing them by their number in the ASCII Table
        for (int i = 0; i < length; i++)
        {
            if (str1[i] > str2[i])
            {
                sign = '>';
            }
            else if (str1[i] == str2[i])
            {
                sign = '=';
            }
            else
            {
                sign = '<';
            }
            Console.WriteLine(str1[i] + " " + sign + " " + str2[i]);
        }
    }
}

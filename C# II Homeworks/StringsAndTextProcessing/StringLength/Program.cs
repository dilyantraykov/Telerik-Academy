/*
Problem 6. String length

Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.
*/

using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        for (int i = input.Length; i < 20; i++)
        {
            input += '*';
        }
        Console.WriteLine(input);
    }
}

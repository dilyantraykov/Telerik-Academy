/*
Problem 2. Reverse string

Write a program that reads a string, reverses it and prints the result at the console.
Example:

input	output
sample	elpmas
*/

using System;
using System.Text;

class Program
{
    static void Main()
    {
        string myString = "sample";
        Console.WriteLine(ReverseString(myString));
    }

    static string ReverseString(string str)
    {
        StringBuilder reverseStr = new StringBuilder(str.Length);
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reverseStr.Append(str[i]);
        }
        return reverseStr.ToString();
    }
}

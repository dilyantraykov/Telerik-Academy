/*
Problem 6. Sum integers

You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
Example:

input	            output
"43 68 9 23 318"    461
*/

using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(SumIntegers(input));
    }

    static int SumIntegers(string input)
    {
        int sum = 0;
        string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var number in numbers)
        {
            sum += int.Parse(number);
        }
        return sum;
    }
}

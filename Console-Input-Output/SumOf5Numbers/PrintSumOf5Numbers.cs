// Problem 7. Sum of 5 Numbers

// Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class PrintSumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Insert 5 numbers separated by spaces: ");
        string input = Console.ReadLine();
        var numbers = input.Split(' ');
        double sum = 0;
        foreach (string n in numbers)
        {
            sum += double.Parse(n);
        }
        Console.WriteLine("The sum is: " + sum);
    }
}


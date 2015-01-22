// Problem 1. Numbers from 1 to N

// Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.

using System;

class NumbersToN
{
    static void Main()
    {
        Console.WriteLine("Insert n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Numbers from 1 to " + n + " are:");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
    }
}


// Problem 9. Matrix of Numbers

// Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.

using System;

class Matrix
{
    static void Main()
    {
        Console.WriteLine("Insert matrix dimension: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write(i+j + " ");
            }
            Console.WriteLine();
        }
    }
}


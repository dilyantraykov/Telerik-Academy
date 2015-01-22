// Problem 9. Sum of n Numbers

// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

using System;

class SumNumbers
{
    static void Main()
    {
        Console.WriteLine("How many numbers?");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Insert number #" + (i+1) + ":");
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum is: " + sum);
    }
}

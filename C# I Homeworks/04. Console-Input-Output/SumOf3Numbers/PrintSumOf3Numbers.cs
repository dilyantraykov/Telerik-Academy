// Problem 1. Sum of 3 Numbers

// Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class PrintSumOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Insert a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert c: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Sum: " + (a+b+c));
    }
}


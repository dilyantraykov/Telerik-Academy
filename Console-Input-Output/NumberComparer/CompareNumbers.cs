// Problem 4. Number Comparer

// Write a program that gets two numbers from the console and prints the greater of them.
// Try to implement this without if statements.

using System;

class CompareNumbers
{
    static void Main()
    {
        Console.WriteLine("Insert a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("The bigger number is: " + (a >= b ? a : b));
    }
}


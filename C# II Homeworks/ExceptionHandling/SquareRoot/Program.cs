/*
Problem 1. Square root

Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.
*/

using System;

class Program
{
    static void Main()
    {
        try
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                throw new ArgumentException();
            }
            Console.WriteLine(Math.Sqrt(n));
        }
        catch
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
}

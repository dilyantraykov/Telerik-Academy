// Problem 1. Odd or Even Integers

// Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Insert number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Number " + n + " is " + ((n % 2 == 0) ? "even" : "odd") + ".");
    }
}


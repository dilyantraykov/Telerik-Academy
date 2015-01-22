// Problem 17.* Calculate GCD

// Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
// Use the Euclidean algorithm (find it in Internet).

using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.WriteLine("Insert a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert b:");
        int b = int.Parse(Console.ReadLine());
        int r = 1;
        int q = 0;
        while (r != 0)
        {
            q = a / b;
            r = a % b;
            a = b;
            if (r != 0)
            {
                b = r;
            }
        }
        Console.WriteLine("GCD=" + b);
    }
}


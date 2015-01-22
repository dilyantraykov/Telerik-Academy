// Problem 18.* Trailing Zeroes in N!

// Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
// Your program should work well for very big numbers, e.g. n=100000.

using System;
using System.Numerics;

class TrailingZeroes
{
    static void Main()
    {
        Console.WriteLine("Insert n:");
        int n = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
        }
        while (nFactorial % 10 == 0)
        {
            count++;
            nFactorial /= 10;
        }
        Console.WriteLine("Number of trailing zeroes in " + n + "! :");
        Console.WriteLine(count);
    }
}


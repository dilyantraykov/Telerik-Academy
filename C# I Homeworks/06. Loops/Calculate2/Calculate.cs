// Problem 6. Calculate N! / K!

// Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
// Use only one loop.

using System;

class Calculate
{
    static void Main()
    {
        Console.WriteLine("Insert n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert k: ");
        int k = int.Parse(Console.ReadLine());
        int kFactorial = 1;
        int nFactorial = 1;
        for (int i = 1; i <= n; i++)
        {
            if (k >= i)
            {
                kFactorial *= i;
            }
            nFactorial *= i;
        }
        Console.WriteLine(nFactorial / kFactorial);
    }
}


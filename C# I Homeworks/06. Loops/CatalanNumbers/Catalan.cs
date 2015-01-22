// Problem 8. Catalan Numbers

// In combinatorics, the Catalan numbers are calculated by the following formula: [catalan-formula]
// Write a program to calculate the nth Catalan number by given n (1 < n < 100).

using System;
using System.Numerics;

class Catalan
{
    static void Main()
    {
        Console.WriteLine("Insert n: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger twoNFactorial = 1;
        for (int i = 1; i <= 2*n; i++)
        {
            if (n >= i)
            {
                nFactorial *= i;
            }
            twoNFactorial *= i;
        }
        BigInteger catalan = twoNFactorial / (nFactorial * nFactorial * (n + 1));
        Console.WriteLine(catalan);
    }
}

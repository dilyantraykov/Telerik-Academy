// Problem 7. Calculate N! / (K! * (N-K)!)

// In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: [formula] For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
// Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

using System;
using System.Numerics;

class Calculate
{
    static void Main()
    {
        Console.WriteLine("Insert n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert k: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger nMinusKFactorial = 1;
        for (int i = 1; i <= n; i++)
        {
            if (k >= i)
            {
                kFactorial *= i;
            }
            if (n-k >= i)
            {
                nMinusKFactorial *= i;
            }
            nFactorial *= i;
        }
        Console.WriteLine(nFactorial / (kFactorial * nMinusKFactorial));
    }
}

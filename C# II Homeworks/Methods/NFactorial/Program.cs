/*
Problem 10. N Factorial

Write a program to calculate n! for each n in the range [1..100].
Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
*/

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        for (int i = 1; i < 100; i++)
        {
            Console.WriteLine(Factorial(i));
        }
    }

    static BigInteger Factorial(int n)
    {
        if(n<=1)
        {
            return 1;
        }

        return n*Factorial(n-1);
    }
}

// Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN

// Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
// Use only one loop. Print the result with 5 digits after the decimal point.

using System;

class Calculate
{
    static void Main()
    {
        Console.WriteLine("Insert n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert x: ");
        int x = int.Parse(Console.ReadLine());
        double S = 1;
        int factorial = 1;
        int power = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            power *= x;
            S += (double)factorial / power;
        }
        Console.WriteLine("{0:F5}", S);
    }
}
// Problem 8. Prime Number Check

// Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

using System;

class CheckPrimer
{
    static void Main()
    {
        Console.WriteLine("Insert n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Is n prime?");
        Console.WriteLine(isPrime(n) ? "Yes!" : "No!");
    }

    static bool isPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}


// Problem 10. Fibonacci Numbers

// Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;

class Fibonacci
{
    public static int FibonacciSequence(int n)
    {
        if (n==0)
        {
            return 0;
        }
        if (n==1)
        {
            return 1;
        }
        return FibonacciSequence(n - 1) + FibonacciSequence(n - 2);
    }

    static void Main()
    {
        Console.WriteLine("Insert n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The first " + n + " Fibonacci numbers are:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(FibonacciSequence(i) + (i != n-1 ? ", " : "\r\n"));
        }
    }
}


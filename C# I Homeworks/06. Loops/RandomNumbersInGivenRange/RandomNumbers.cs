// Problem 11. Random Numbers in Given Range

// Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

class RandomNumbers
{
    static void Main()
    {
        Console.WriteLine("Insert n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert min: ");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert max: ");
        int max = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        Console.WriteLine(n + " random numbers between " + min + " and " + max + ":");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(randomGenerator.Next(min, max+1));
        }
    }
}


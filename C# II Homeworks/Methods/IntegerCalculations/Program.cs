/*
Problem 14. Integer calculations

Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Min: {0}", Min(6, 3, 1, 2, 12));
        Console.WriteLine("Max: {0}", Max(5, 3, 6, 1));
        Console.WriteLine("Average: {0}", Average(1, 2, 3, 4, 5, 6));
        Console.WriteLine("Sum: {0}", Sum(2, 2, 1, 4));
        Console.WriteLine("Product: {0}", Product(7, 5, 4));
    }

    static int Product(params int[] sequence)
    {
        int product = 1;

        for (int i = 0; i < sequence.Length; i++)
        {
            product *= sequence[i];
        }
        return product;
    }

    static int Sum(params int[] sequence)
    {
        int sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        return sum;
    }

    static double Average(params int[] sequence)
    {
        double sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        return sum / sequence.Length;
    }

    static int Max(params int[] sequence)
    {
        int max = int.MinValue;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] > max)
            {
                max = sequence[i];
            }
        }
        return max;
    }

    static int Min(params int[] sequence)
    {
        int min = int.MaxValue;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] < min)
            {
                min = sequence[i];
            }
        }
        return min;
    }
}

// Problem 12.* Zero Subset

// We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
// Assume that repeating the same subset several times is not a problem.

using System;

class SubsetZero
{
    static void PrintSubset(int?[] subset, int size)
    {
        Console.Write("[ ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(subset[i] + ((subset[i] == null) ? "" : " "));
        }
        Console.WriteLine(" ]");
    }
    static void Main()
    {
        int?[] numbers = new int?[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Insert number #" + (i+1));
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int count = 0;
        for (int i = 0; i < Math.Pow(2, 5); i++) // 5 numbers make a total of 32 sets
        {
            int?[] subset = new int?[5];
            int? sum = null;
            for (int j = 0; j < 5; j++)
            {
                if ((i & (1 << (5 - j - 1))) != 0) // goes through each combination of 5 numbers in a set
                {
                    if (sum == null)
                    {
                        sum = 0;
                    }
                    subset[j] = numbers[j];
                    sum += numbers[j];
                }
            }
            if (sum == 0 && sum != null)
            {
                count++;
                if (count == 1)
                {
                    Console.WriteLine("The subsets with sum of 0 are: ");
                }
                PrintSubset(subset, 5);
            }
        }
        if (count == 0)
        {
            Console.WriteLine("no zero subset");
        }
    }
}


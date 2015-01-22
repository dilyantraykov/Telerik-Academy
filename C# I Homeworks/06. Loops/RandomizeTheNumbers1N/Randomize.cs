// Problem 12.* Randomize the Numbers 1…N

// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;

class Randomize
{
    static void Main()
    {
        Console.WriteLine("Insert n: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Random randomGenerator = new Random();
        for (int i = 1; i <= n; i++)
        {
            while (true)
            {
                int randomIndex = randomGenerator.Next(0, n);
                if (numbers[randomIndex] == 0)
                {
                    numbers[randomIndex] = i;
                    break;
                }
            }
        }
        Console.WriteLine("The numbers from 1 to " + n + " in random order:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}


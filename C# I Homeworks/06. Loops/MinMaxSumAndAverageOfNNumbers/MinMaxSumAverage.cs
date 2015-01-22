// Problem 3. Min, Max, Sum and Average of N Numbers

// Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
// The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
// The output is like in the examples below.

using System;

class MinMaxSumAverage
{
    static void Main()
    {
        Console.WriteLine("Insert n:");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        double avg = 0;
        int max, min;
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Insert number #" + (i+1) + ":");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        max = numbers[0];
        min = numbers[0];
        for (int i = 0; i < n; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            sum += numbers[i];
        }
        avg = (double)sum / n;
        Console.WriteLine("min = " + min);
        Console.WriteLine("max = " + max);
        Console.WriteLine("sum = " + sum);
        Console.WriteLine("avg = {0:F2}", avg);
    }
}


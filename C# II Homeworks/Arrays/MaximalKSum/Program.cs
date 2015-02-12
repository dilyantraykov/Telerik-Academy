/*
Problem 6. Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the array: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number K: ");
        int K = int.Parse(Console.ReadLine());
        int[] numbers = new int[N];
        int sum = 0;
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Enter array element #{0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);
        Console.WriteLine("The elements of the array with a maximum sum are: ");
        for (int i = 0; i < K; i++)
        {
            Console.Write(numbers[N - 1 - i] + (i == K - 1 ? "" : ","));
            sum += numbers[N - 1 - i];
        }
        Console.WriteLine();
        Console.WriteLine("And their sum is {0}", sum);
    }
}

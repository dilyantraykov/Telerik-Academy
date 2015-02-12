/*
Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the arrays: ");
        int N = int.Parse(Console.ReadLine());
        int[] numbers1 = new int[N];
        int[] numbers2 = new int[N];
        char sign = '>';
        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter integer {0} of array 1: ", i + 1);
            numbers1[i] = int.Parse(Console.ReadLine());
            Console.Write("Enter integer {0} of array 2: ", i + 1);
            numbers2[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < N; i++)
        {
            if (numbers1[i] > numbers2[i])
            {
                sign = '>';
            }
            else if (numbers1[i] == numbers2[i])
            {
                sign = '=';
            }
            else
            {
                sign = '<';
            }
            Console.WriteLine(numbers1[i] + " " + sign + " " + numbers2[i]);
        }
    }
}


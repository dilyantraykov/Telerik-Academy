/*
Problem 1. Allocate array

Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.
*/

using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[20];
        for (int i = 0; i < 20; i++)
        {
            numbers[i] = i*5;
        }
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}

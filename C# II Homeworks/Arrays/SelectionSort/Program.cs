/*
Problem 7. Selection sort

Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
*/

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 6, 2, 32, 5, 8, 1, 10, 4 }; // for your convinience, the array is predefined
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min = arr[i];
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < min)
                {
                    min = arr[j];
                    int temp = arr[i];
                    arr[i] = min;
                    arr[j] = temp;
                }
            }
        }
        Console.WriteLine(String.Join(",", arr));
    }
}

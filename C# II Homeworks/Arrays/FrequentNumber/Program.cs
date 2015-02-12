/*
Problem 9. Frequent number

Write a program that finds the most frequent number in an array.
Example:

input	                                    result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	    4 (5 times)
*/

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 }; // for your convinience, the array is predefined
        int maxCount = 0;
        int maxValue = 0;
        Array.Sort(arr);
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int count = 1;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] == arr[i])
                {
                    count++;
                }
            }
            if (count > maxCount)
            {
                maxCount = count;
                maxValue = arr[i];
            }
        }
        Console.WriteLine("{0} ({1} times)", maxValue, maxCount);
    }
}

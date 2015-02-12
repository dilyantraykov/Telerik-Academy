/*
Problem 8. Maximal sum

Write a program that finds the sequence of maximal sum in given array.
Example:

input	                                result
2, 3, -6, -1, 2, -1, 6, 4, -8, 8	    2, -1, 6, 4

Can you do it with only one loop (with single scan through the elements of the array)?
*/

using System;

class Program
{
    static void Main()
    {


        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 }; // for your convinience, the array is predefined
        int maxSum = 0;
        int startIndex = 0;
        int endIndex = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int currentSum = 0;
            for (int j = i; j < arr.Length; j++)
            {
                currentSum += arr[j];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    startIndex = i;
                    endIndex = j;
                }
            }
        }
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(arr[i] + (i == endIndex ? "" : ","));
        }
        Console.WriteLine();
    }
}

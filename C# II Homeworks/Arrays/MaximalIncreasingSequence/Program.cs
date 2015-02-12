/*
Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.
Example:

input	                    result
3, 2, 3, 4, 2, 2, 4	        2, 3, 4
*/

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 3, 2, 3, 4, 2, 2, 4 }; // for your convinience, the array is predefined
        int maxCount = 1;
        int maxCountValue = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int count = 1;
            for (int j = i; j < arr.Length - 1; j++)
            {
                if (arr[j] == arr[j+1] - 1)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            if (count > maxCount)
            {
                maxCount = count;
                maxCountValue = arr[i];
                i += maxCount;
            }
        }
        for (int i = 0; i < maxCount; i++)
        {
            Console.Write((maxCountValue + i) + (i != maxCount - 1 ? "," : ""));
        }
        Console.WriteLine();
    }
}

/*
Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array.
Example:

input	                            result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1	    2, 2, 2
*/

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 }; // for your convinience, the array is predefined
        int maxCount = 1;
        int maxCountValue = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int count = 1;
            for (int j = i + 1; j < arr.Length - 1; j++)
            {
                if (arr[i] == arr[j])
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
            Console.Write(maxCountValue + (i != maxCount - 1 ? "," : ""));
        }
        Console.WriteLine();
    }
}

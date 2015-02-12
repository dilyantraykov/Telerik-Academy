/*
Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of given sum S (if present).
Example:

array	                   S	    result
4, 3, 1, 4, 2, 5, 8	       11	    4, 2, 5
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
        List<int> sumArr = new List<int>();
        int S = int.Parse(Console.ReadLine());
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int sum = arr[i];
            sumArr.Add(arr[i]);
            for (int j = i + 1; j < arr.Length; j++)
            {
                sum += arr[j];
                sumArr.Add(arr[j]);
                if (sum == S)
                {
                    break;
                }
            }
            if (sum != S)
            {
                sumArr.Clear();
            }
            else
            {
                break;
            }
        }
        foreach (var item in sumArr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

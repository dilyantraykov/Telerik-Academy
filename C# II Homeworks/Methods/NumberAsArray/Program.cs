/*
Problem 8. Number as array

Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.
*/

using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main()
    {
        int[] arr1 = { 1, 2, 3, 4, 4 };
        int[] arr2 = { 5, 9, 8, 2 };
        // 44321 + 2895 = 47216
        Console.WriteLine(Add(arr1, arr2));
    }

    static BigInteger Add(int[] arr1, int[] arr2)
    {
        int[] bigger = arr1;
        int[] smaller = arr2;
        if (arr2.Length > bigger.Length)
        {
            bigger = arr2;
            smaller = arr1;
        }
        List<int> sum = new List<int>();
        for (int i = 0; i < smaller.Length; i++)
        {
            sum.Add((arr1[i] + arr2[i]) % 10);
            if (arr1[i] + arr2[i] >= 10)
            {
                bigger[i + 1]++;
            }
        }
        for (int i = 0; i < bigger.Length - smaller.Length; i++)
        {
            sum.Add(bigger[bigger.Length - 1 - i]);
        }
        string finalSum = "";
        for (int i = sum.Count - 1; i >= 0; i--)
        {
            finalSum += sum[i];
        }
        return BigInteger.Parse(finalSum);
    }
}

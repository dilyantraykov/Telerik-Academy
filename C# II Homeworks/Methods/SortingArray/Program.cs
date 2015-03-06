/*
Problem 9. Sorting array

Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.
*/

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 2, 3, 8, 11, 22, 24, 44, 52, 51, 33 };
        foreach (var item in SortArrayAscending(arr))
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(new string('=', 50));
        foreach (var item in SortArrayDescending(arr))
        {
            Console.WriteLine(item);
        }
    }

    static int[] SortArrayDescending(int[] arr)
    {
        int[] sortedArray = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            sortedArray[i] = arr[MaximalElement(arr, i)];
            int temp = arr[MaximalElement(arr, i)];
            arr[MaximalElement(arr, i)] = arr[i];
            arr[i] = temp;
        }
        return sortedArray;
    }

    static int[] SortArrayAscending(int[] arr)
    {
        int[] newArr = SortArrayDescending(arr);
        Array.Reverse(newArr);
        return newArr;
    }

    static int MaximalElement(int[] arr, int index)
    {
        if (index >= arr.Length)
        {
            return -1;
        }
        else if (index == arr.Length - 1)
        {
            return index;
        }

        int maxIndex = index;
        for (int i = index + 1; i < arr.Length; i++)
        {
            if (arr[i] > arr[maxIndex])
            {
                maxIndex = i;
            }
        }
        return maxIndex;
    }
}

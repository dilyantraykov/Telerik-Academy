/*
Problem 14. Quick sort

Write a program that sorts an array of strings using the Quick sort algorithm.
*/

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 6, 2, 32, 5, 8, 1, 10, 4 }; // for your convinience, the array is predefined
        QuickSort(arr, 0, arr.Length - 1);
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    public static void QuickSort(int[] input, int left, int right)
    {
        if (left < right)
        {
            int q = Partition(input, left, right);
            QuickSort(input, left, q - 1);
            QuickSort(input, q + 1, right);
        }
    }

    private static int Partition(int[] input, int left, int right)
    {
        int pivot = input[right];
        int temp;
 
        int i = left;
        for (int j = left; j < right; j++)
        {
            if (input[j] <= pivot)
            {
                temp = input[j];
                input[j] = input[i];
                input[i] = temp;
                i++;
            }
        }
 
        input[right] = input[i];
        input[i] = pivot;
 
        return i;
    }
}

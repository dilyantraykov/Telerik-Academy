/*
Problem 4. Binary search

Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
*/

using System;

class Program
{
    static void Main()
    {
        /*Console.Write("Enter array size: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Enter element #{0}", i+1);
            array[i] = int.Parse(Console.ReadLine());
        }*/
        int[] array = { 5, 2, 6, 1, 8, 9, 3 }; // for your convenience, the array is predefined
        int K = int.Parse(Console.ReadLine());
        Array.Sort(array);
        int binarySearchIndex = Array.BinarySearch(array, K);
        /*
        Binary Search Return Value:
        The index of the specified value in the specified array, if value is found. If value is not found and value is less
        than one or more elements in array, a negative number which is the bitwise complement of the index of the first element
        that is larger than value. If value is not found and value is greater than any of the elements in array, a negative number
        which is the bitwise complement of (the index of the last element plus 1).
        */

        if (binarySearchIndex < -1)
        {
            Console.WriteLine(array[~binarySearchIndex - 1]);
        }
        else if (~binarySearchIndex == 0)
        {
            Console.WriteLine("No such number");
        }
        else
        {
            Console.WriteLine(array[binarySearchIndex]);
        }
    }
}

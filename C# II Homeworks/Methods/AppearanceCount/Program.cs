/*
Problem 4. Appearance count

Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.
*/

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 2, 3, 8, 11, 22, 2, 4, 2, 5, 3 };
        Console.WriteLine(AppearanceCount(arr, 3));
    }

    static int AppearanceCount(int[] arr, int number)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
            {
                count++;
            }
        }
        return count;
    }
}

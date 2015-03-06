/*
Problem 5. Larger than neighbours

Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
*/

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 2, 3, 8, 11, 22, 2, 4, 2, 5, 3 };
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine(LargerThanNeighbours(arr, index));
    }

    static bool LargerThanNeighbours(int[] arr, int index)
    {
        bool largerThanLeft = true;
        bool largerThanRight = true;
        if (index > 0)
        {
            if (arr[index] <= arr[index - 1])
            {
                largerThanLeft = false;
            }
        }
        else
        {
            return false;
        }
        if (index < arr.Length - 1)
        {
            if (arr[index] <= arr[index + 1])
            {
                largerThanRight = false;
            }
        }
        else
        {
            return false;
        }
        if (largerThanLeft && largerThanRight)
        {
            return true;
        }
        return false;
    }
}

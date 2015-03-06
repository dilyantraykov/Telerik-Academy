/*
Problem 6. First larger than neighbours

Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.
*/

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 2, 3, 8, 11, 22, 24, 44, 52, 56, 333 };
        int index = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (LargerThanNeighbours(arr, i))
            {
                index = i;
                break;
            }
        }
        Console.WriteLine(index);
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


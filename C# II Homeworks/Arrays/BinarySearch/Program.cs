/*
Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> arr = new List<int>() { 2, 2, 3, 3, 4, 5, 8 };
        int X = int.Parse(Console.ReadLine());
        int startIndex = 0;
        int endIndex = arr.Count - 1;
        int middleIndex = (startIndex + endIndex) / 2;
        bool found = false;
        while (startIndex <= endIndex)
        {
            middleIndex = (startIndex + endIndex) / 2;
            if (arr[middleIndex] == X)
            {
                found = true;
                break;
            }
            else if (arr[middleIndex] > X)
            {
                endIndex = middleIndex - 1;
            }
            else
            {
                startIndex = middleIndex + 1; 
            }
        }
        if (found)
        {
            Console.WriteLine(middleIndex);
        }
        else
        {
            Console.WriteLine("Not found");
        }
    }
}

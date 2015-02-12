/*
Problem 16.* Subset with sum S

We are given an array of integers and a number S.
Write a program to find if there exists a subset of the elements of the array that has a sum S.
Example:

input array	               S	  result
2, 1, 2, 4, 3, 5, 2, 6     14     yes
*/

using System;

class Program
{
    static void Main()
    {
        int[] source = new int[] { 2, 4, 5 }; 
        int S = int.Parse(Console.ReadLine());
        bool found = false;
        for (int i = 0; i < Math.Pow(2, source.Length); i++)
        {
            int sum = 0;
            for (int j = 0; j < source.Length; j++)
            {
                if ((i & (1 << (source.Length - j - 1))) != 0)
                {
                    sum += source[j];
                }
            }
            if (sum == S)
            {
                found = true;
            }
        }
        Console.WriteLine(found ? "Yes" : "No");
    }
}

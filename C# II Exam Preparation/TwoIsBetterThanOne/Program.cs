/*
Condition
*/

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

class Program
{
    static bool IsPalindrome(string numberAsString)
    {
        for (int j = 0; j < numberAsString.Length / 2; j++)
        {
            if (numberAsString[j] != numberAsString[numberAsString.Length - j - 1] || (numberAsString[j] != '3' && numberAsString[j] != '5'))
            {
                return false;
            }
        }
        return true;
    }

    static int FindNumberOfPalindromes(long A, long B)
    {
        int count = 0;
        var numbers = new List<long> { 3, 5 };
        int left = 0;
        long max = 1000000000000000000;

        while (left < numbers.Count)
        {
            int right = numbers.Count;
            for (int i = left; i < right; i++)
            {
                if (numbers[i] < max)
                {
                    numbers.Add((numbers[i] * 10) + 3);
                    numbers.Add((numbers[i] * 10) + 5);
                }
            }
            left = right;
        }

        foreach (var number in numbers)
        {
            if (number >= A && number <= B && IsPalindrome(number.ToString()))
            {
                count++;
            }
        }
        return count;
    }

    static int FindNumberInTask2(string[] numbersAsStrings, int P)
    {
        int[] numbers = new int[numbersAsStrings.Length];
        for (int i = 0; i < numbersAsStrings.Length; i++)
        {
            numbers[i] = int.Parse(numbersAsStrings[i]);
        }
        Array.Sort(numbers);
        //Array.Reverse(numbers);
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            count = 0;
            for (int j = i; j < numbers.Length; j++)
            {
                if (numbers[i] >= numbers[j])
                {
                    count++;
                }
            }
            count += i;
            double percent = (double)count / numbers.Length * 100;
            if (percent >= P)
            {
                return numbers[i];
            }
        }
        return numbers[0];
    }

    static void Main()
    {
        var intervalAB = Console.ReadLine().Split(' ');
        var A = long.Parse(intervalAB[0]);
        var B = long.Parse(intervalAB[1]);
        var numbers = Console.ReadLine().Split(',');
        int P = int.Parse(Console.ReadLine());


        Console.WriteLine(FindNumberOfPalindromes(A, B));
        Console.WriteLine(FindNumberInTask2(numbers, P));
    }
}

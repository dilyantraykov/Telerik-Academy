/*
Problem 4. Sub-string in text

Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
Example:

The target sub-string is in

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9
*/

using System;

class Program
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        Console.WriteLine(CountSubstring(text, "in"));
    }

    static int CountSubstring(string text, string substring)
    {
        int index = 0;
        int count = 0;
        while (index >= 0)
        {
            index = text.IndexOf(substring, index + 1, StringComparison.OrdinalIgnoreCase);
            if (index >= 0)
            {
                count++;
            }
        }
        return count;
    }
}

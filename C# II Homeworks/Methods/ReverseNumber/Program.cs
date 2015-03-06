/*
Problem 7. Reverse number

Write a method that reverses the digits of given decimal number.
Example:

input	    output
256	        652
123.45	    54.321
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(ReverseNumber(256));
        Console.WriteLine(ReverseNumber(123456));
        Console.WriteLine(ReverseNumber(123.45M));
    }

    static decimal ReverseNumber(decimal number)
    {
        string num = number.ToString();
        string newNum = "";
        for (int i = num.Length-1; i >= 0; i--)
        {
            newNum += num[i];
        }
        return Convert.ToDecimal(newNum);
    }
}

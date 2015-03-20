/*
Problem 6. Divisible by 7 and 3

Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
*/

using System;
using System.Linq;

class NumbersDivisibleBy7And3
{
    static void Main()
    {
        var numbers = new[] {12, 5, 63, 11, 22, 55, 10, 21, 1};

        //var numbersDivisibleBy7And3 = numbers.Where(number => number%7 == 0 && number%3 == 0);

        var numbersDivisibleBy7And3 =
            from number in numbers
            where number%7 == 0 && number%3 == 0
            select number;

        foreach (var number in numbersDivisibleBy7And3)
        {
            Console.WriteLine(number);
        }
    }
}

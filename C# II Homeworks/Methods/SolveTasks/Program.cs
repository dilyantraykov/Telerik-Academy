/*
Problem 13. Solve tasks

Write a program that can solve these tasks:
    Reverses the digits of a number
    Calculates the average of a sequence of integers
    Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
    The decimal number should be non-negative
    The sequence should not be empty
    a should not be equal to 0
*/

using System;

class Program
{
    static decimal ReverseDecimal(decimal number)
    {
        char[] ch = number.ToString().ToCharArray();
        Array.Reverse(ch);
        return decimal.Parse(new string(ch));
    }

    static double CalculateAverage(params int[] numbers)
    {
        double sum = 0;

        foreach (var i in numbers)
        {
            sum += i;
        }

        return (double)(sum / numbers.Length);
    }

    static double SolveLinearEquation(double a, double b)
    {
        return (b / a) * (-1);
    }

    static void Main()
    {
        Console.WriteLine("Please choose the problem to solve: ");
        Console.WriteLine("1. Reverse the digits of a number");
        Console.WriteLine("2. Calculate the average of a sequence of integers");
        Console.WriteLine("3. Solve a linear equation a * x + b = 0");
        var key = Console.ReadLine();

        switch (key)
        {
            case "1":
                Console.WriteLine("Enter non negative decimal number: ");
                decimal n = decimal.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Number should be positive!");
                }
                else
                {
                    Console.WriteLine("Reversed: " + ReverseDecimal(n));
                }
                break;

            case "2":
                Console.WriteLine("Enter number of elements: ");
                int m = int.Parse(Console.ReadLine());
                int[] numbers = new int[m];

                if (m <= 0)
                {
                    Console.WriteLine("You should enter at least one element!");
                }
                else
                {
                    for (int i = 0; i < m; i++)
                    {
                        Console.WriteLine("Enter number {0}: ", i + 1);
                        numbers[i] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Average is: " + CalculateAverage(numbers));
                }
                break;
            case "3":
                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());

                if (a == 0)
                {
                    Console.WriteLine("A should not be zero!");
                }
                else
                {
                    Console.WriteLine("x = " + SolveLinearEquation(a, b));
                }
                break;
            default:
                Console.WriteLine("Invalid input!");
                break;
        }
    }
}
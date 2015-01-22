// Problem 7. Sort 3 Numbers with Nested Ifs

// Write a program that enters 3 real numbers and prints them sorted in descending order.
// Use nested if statements.
// Note: Don’t use arrays and the built-in sorting functionality.

using System;

class Sort3Numbers
{
    static void Main()
    {
        Console.WriteLine("Insert a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert c: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("The numbers in descending order are:");
        if (a >= b && a >= c)
        {
            if (b >= c)
            {
                Console.WriteLine(a + " " + b + " " + c);
            }
            else
            {
                Console.WriteLine(a + " " + c + " " + b);
            }
        }
        else if (b >= a && b >= c)
        {
            if (a >= c)
            {
                Console.WriteLine(b + " " + a + " " + c);
            }
            else
            {
                Console.WriteLine(b + " " + c + " " + a);
            }
        }
        else
        {
            if (a >= b)
            {
                Console.WriteLine(c + " " + a + " " + b);
            }
            else
            {
                Console.WriteLine(c + " " + b + " " + a);
            }
        }
    }
}


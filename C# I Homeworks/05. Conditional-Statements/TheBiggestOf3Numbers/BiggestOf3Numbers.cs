// Problem 5. The Biggest of 3 Numbers

// Write a program that finds the biggest of three numbers.

using System;

class BiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Insert a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert c: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("The biggest number is:");
        if (a >= b)
        {
            if (a >= c)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
        else if (b > a)
        {
            if (b >= c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}


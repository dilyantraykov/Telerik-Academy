// Problem 6. Quadratic Equation

// Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
using System;

class QuadEquation
{
    static void Equation(double a, double b, double c)
    {
        double D = (b * b) - (4 * a * c);
        if (D > 0)
        {
            Console.WriteLine("x1 = " + (Math.Sqrt(D) + b) / (2 * a));
            Console.WriteLine("x2 = " + (Math.Sqrt(D) - b) / (2 * a));
        }
        else if (D==0)
        {
            Console.WriteLine("x1 = x2 = " + (b) / (2 * a));
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }

    static void Main()
    {
        Console.WriteLine("Insert a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert c: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("The solution to " + a + "x^2 + " + b + "x + " + c + " = 0 is");
        Equation(a, b, c);
    }
}


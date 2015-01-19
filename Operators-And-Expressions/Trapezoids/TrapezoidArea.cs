// Problem 9. Trapezoids

// Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Insert trapezoid side a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert trapezoid side b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert trapezoid height: ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Trapezoid area: " + ((a+b)/2)*h);
    }
}

